using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class Fees : Form
    {
        private static Fees frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Fees GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Fees();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        private const int _v = 0;

        public Fees()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            repo.DisplayFees(FeesDGV);
            repo.DisplayStudents(StudentsDGV);
            repo.FillStId(StdIdCb);
        }
        ~Fees()
        {
            Dispose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
        #region old connection way
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");       
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion


        private void Reset()
        {
            StNameTb.Text = "0";
            StdIdCb.SelectedIndex = -1;
            FeesBookTb.Text = "0";
            FeesClothTb.Text = "0";
            FeesBusTb.Text = "0";
            FeesTb.Text = "0";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("Select SUM(StFeesTotal) from StudentTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            repo._db.conn.Close();
            if (dt.Rows[0][0].ToString() == "0")
            {
                repo.DisplayFees(FeesDGV);
                Reset();
                _ = MessageBox.Show("لا يوجد مصروفات");
            }
            else
            {
                string paymentPeriod = PeriodDate.Value.Month.ToString() + "/" + PeriodDate.Value.Year.ToString();
                if (repo._db.conn.State == ConnectionState.Closed)
                {
                    repo._db.conn.Open();
                }
                DataTable dt1 = new DataTable();
                _ = new SqlDataAdapter("select Count(*) from FeesTbl where StId= '" + StdIdCb.SelectedValue.ToString() + "'and Montth= '" + paymentPeriod.ToString() + "'", repo._db.conn);
                _ = sda.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    _ = MessageBox.Show("لا يوجد اقساط للدفع خلال هذا الشهر تم الدفع مسبقا");
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("insert into FeesTbl(StId,StName,Montth,StFeesBook,StFeesCloth,StFeesBus,StFees)values(@Stid,@Stname,@Montth,@StFeesBook,@StFeesCloth,@StFeesBus,@StFees)", repo._db.conn);
                        _ = cmd.Parameters.AddWithValue("@Stid", StdIdCb.SelectedValue.ToString());
                        _ = cmd.Parameters.AddWithValue("@Stname", StNameTb.Text);
                        _ = cmd.Parameters.AddWithValue("@Montth", paymentPeriod);
                        _ = cmd.Parameters.AddWithValue("@StFeesBook", FeesBookTb.Text);
                        _ = cmd.Parameters.AddWithValue("@StFeesCloth", FeesClothTb.Text);
                        _ = cmd.Parameters.AddWithValue("@StFeesBus", FeesBusTb.Text);
                        _ = cmd.Parameters.AddWithValue("@StFees", FeesTb.Text);
                        _ = cmd.ExecuteNonQuery();
                        _ = MessageBox.Show("تم دفع القسط بنجاح");
                        SqlCommand cmd2 = new SqlCommand("update StudentTbl set StFeesBook =StFeesBook-@StFeesBook2,StFeesCloth=StFeesCloth-@StFeesCloth2,StFeesBus=StFeesBus-@StFeesBus2,StFees=StFees-@StFees2 where StId='" + StdIdCb.SelectedValue.ToString() + "'", repo._db.conn);
                        _ = cmd2.Parameters.AddWithValue("@StFeesBook2", FeesBookTb.Text);
                        _ = cmd2.Parameters.AddWithValue("@StFeesCloth2", FeesClothTb.Text);
                        _ = cmd2.Parameters.AddWithValue("@StFeesBus2", FeesBusTb.Text);
                        _ = cmd2.Parameters.AddWithValue("@StFees2", FeesTb.Text);
                        _ = cmd2.ExecuteNonQuery();
                        _ = MessageBox.Show("تم تحديث بياتات الطالب");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show(ex.Message);

                    }
                }
                repo._db.conn.Close();
                repo.DisplayFees(FeesDGV);
                Reset();
            }
        }
        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            repo.GetStuName(StdIdCb, StageCb, StNameTb);
        }

        private int _key = _v;

        public Fees(int key)
        {
            _key = key;
        }

        private void FeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = PeriodDate.Value.Month.ToString() + "/" + PeriodDate.Value.Year.ToString();
            StdIdCb.Text = FeesDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = FeesDGV.SelectedRows[0].Cells[2].Value.ToString();
            _ = FeesDGV.SelectedRows[0].Cells[3].Value.ToString();
            FeesBookTb.Text = FeesDGV.SelectedRows[0].Cells[4].Value.ToString();
            FeesClothTb.Text = FeesDGV.SelectedRows[0].Cells[5].Value.ToString();
            FeesBusTb.Text = FeesDGV.SelectedRows[0].Cells[6].Value.ToString();
            FeesTb.Text = FeesDGV.SelectedRows[0].Cells[7].Value.ToString();
            _key = StNameTb.Text == "" ? 0 : Convert.ToInt32(FeesDGV.SelectedRows[0].Cells[0].Value.ToString());
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.FeesTbl' table. You can move, or remove it, as needed.
            _ = feesTblTableAdapter.Fill(schoolDBDataSet1.FeesTbl);
            // TODO: This line of code loads data into the 'schoolDBDataSet1.StudentTbl' table. You can move, or remove it, as needed.
            _ = studentTblTableAdapter.Fill(schoolDBDataSet1.StudentTbl);

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            repo.SerachST("StudentTbl", StudentsDGV, searchtxt.Text);

        }

        private void searchtxt2_TextChanged(object sender, EventArgs e)
        {
            repo.SerachST("FeesTbl", FeesDGV, searchtxt2.Text);

            //string query = "select * from FeesTbl where StName like'" + searchtxt2.Text + "%'";
            //if (repo._db.conn.State == ConnectionState.Closed)
            //{
            //    repo._db.conn.Open();
            //}
            //SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //_ = adapter.Fill(dt);
            //FeesDGV.DataSource = dt;
            //repo._db.conn.Close();
        }
      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=========حضانة اقرا==========", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Green, new Point(200, 40));
            e.Graphics.DrawString("=========ايصال دفع==========", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Blue, new Point(208, 65));
            e.Graphics.DrawString("Id:" + FeesDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 105));
            e.Graphics.DrawString("Name:" + FeesDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString("Month:" + FeesDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 145));
            e.Graphics.DrawString("Books:" + FeesDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 170));
            e.Graphics.DrawString("Uniform:" + FeesDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 190));
            e.Graphics.DrawString("Bus:" + FeesDGV.SelectedRows[0].Cells[5].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 210));
            e.Graphics.DrawString("Fees:" + FeesDGV.SelectedRows[0].Cells[6].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 230));
            e.Graphics.DrawString("________________________________________", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Green, new Point(10, 240));
            e.Graphics.DrawString("Total:" + FeesDGV.SelectedRows[0].Cells[7].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 270));
            e.Graphics.DrawString(":امضاء", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Black, new Point(208, 300));
        }
        private bool disposed = false;
        protected virtual void Dispose1(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    repo._db.conn.Dispose();
                }
            }
        }
        public new void Dispose()
        {
            Dispose1(true);
            GC.SuppressFinalize(this);
        }
    }
}
