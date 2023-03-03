using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MainMenu = SchoolSystemERp.MainMenu;

namespace SchoolSystemERP
{
    public partial class StResults : Form
    {
        private static StResults frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static StResults GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new StResults();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public StResults()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            DisplayResults();
            FillStId();
        }
        ~StResults()
        {
            Dispose();
        }
        #region MyRegion
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion
        private void DisplayResults()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from ResultTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            StResultsDGV.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }

        private void FillStId()
        {
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", repo._db.conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            _ = dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StdIdCb.ValueMember = "StId";
            StdIdCb.DataSource = dt;
            repo._db.conn.Close();
        }
        private void GetStuName()
        {
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SId", repo._db.conn);
            _ = cmd.Parameters.AddWithValue("@SId", StdIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            _ = sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();

            }
            repo._db.conn.Close();
        }
        private void Reset()
        {
            StdIdCb.SelectedIndex = -1;
            StNameTb.Text = "";
            StageCb.SelectedIndex = -1;
            ArabicTb.Text = "0";
            EnglishTb.Text = "0";
            MathTb.Text = "0";
            ResalaTb.Text = "0";
            ActivitiesTb.Text = "0";
            QuaranTb.Text = "0";
            GeographTb.Text = "0";
            RelagionTb.Text = "0";
            NoorBayanTb.Text = "0";
            DiscoverTb.Text = "0";
            TechnologyTb.Text = "0";
            TanmyaTb.Text = "0";
            estqbalTb.Text = "0";
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StageCb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال  الماده  بالقيمه صفر اذا كان الطالب لا يدرسها ");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into ResultTbl(StId,StName,StStage,Arabic,English,Math,Resala,Quaran,Activities,geographic,Relgion,NoorBayan,Discover,Technology,TanmyaMaharat,Estqbal,RMonth)values(@StId,@Sname,@StStage,@Arabic,@English,@Math,@Resala,@Quaran,@Activities,@geographic,@Relgion,@NoorBayan,@Discover,@Technology,@TanmyaMaharat,@Estqbal,@RMonth)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StdIdCb.SelectedValue);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Arabic", ArabicTb.Text);
                    _ = cmd.Parameters.AddWithValue("@English", EnglishTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Math", MathTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Resala", ResalaTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Quaran", ActivitiesTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Activities", QuaranTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Geographic", GeographTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Relgion", RelagionTb.Text);
                    _ = cmd.Parameters.AddWithValue("@NoorBayan", NoorBayanTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Discover", DiscoverTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Technology", TechnologyTb.Text);
                    _ = cmd.Parameters.AddWithValue("@TanmyaMaharat", TanmyaTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Estqbal", estqbalTb.Text);
                    _ = cmd.Parameters.AddWithValue("@RMonth", Dpicker.Value.Date);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة نتيجة الطالب");
                    repo._db.conn.Close();
                    Reset();
                    DisplayResults();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }
        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStuName();

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=========حضانة المنار==========", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Green, new Point(200, 40));
            e.Graphics.DrawString("=========النتيجه==========", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 65));
            e.Graphics.DrawString("Id:" + StResultsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 105));
            e.Graphics.DrawString("الاسم:" + StResultsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString("المرحله:" + StResultsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 145));
            e.Graphics.DrawString("لغه عربيه:" + StResultsDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 170));
            e.Graphics.DrawString("لغه انجليزيه:" + StResultsDGV.SelectedRows[0].Cells[5].Value.ToString(), new Font("Abeezee", 18, FontStyle.Italic), Brushes.Black, new Point(120, 190));
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(StResultsDGV.Width, StResultsDGV.Height);
            StResultsDGV.DrawToBitmap(bmp, new Rectangle(0, 0, StResultsDGV.Width, StResultsDGV.Height));
            e.Graphics.DrawImage(bmp, 0, 0, StResultsDGV.Width, StResultsDGV.Height);
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            _ = printPreviewDialog2.ShowDialog();
        }

        private int _key = 0;
        private void EditResult_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StageCb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال  الماده  بالقيمه صفر اذا كان الطالب لا يدرسها ");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("update  ResultTbl set StId=@StId,StName=@Sname,StStage=@StStage,Arabic=@Arabic,English=@English,Math=@Math,Resala=@Resala,Quaran=@Quaran,Activities=@Activities,geographic=@geographic,Relgion=@Relgion,NoorBayan=@NoorBayan,Discover=@Discover,Technology=@Technology,TanmyaMaharat=@TanmyaMaharat,Estqbal=@Estqbal,RMonth=@RMonth where ResId=@rsid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StdIdCb.SelectedValue);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Arabic", ArabicTb.Text);
                    _ = cmd.Parameters.AddWithValue("@English", EnglishTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Math", MathTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Resala", ResalaTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Quaran", ActivitiesTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Activities", QuaranTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Geographic", GeographTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Relgion", RelagionTb.Text);
                    _ = cmd.Parameters.AddWithValue("@NoorBayan", NoorBayanTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Discover", DiscoverTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Technology", TechnologyTb.Text);
                    _ = cmd.Parameters.AddWithValue("@TanmyaMaharat", TanmyaTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Estqbal", estqbalTb.Text);
                    _ = cmd.Parameters.AddWithValue("@RMonth", Dpicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("rsid", _key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة نتيجة الطالب");
                    repo._db.conn.Close();
                    Reset();
                    DisplayResults();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }
        private void StResultsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdIdCb.SelectedItem = StResultsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = StResultsDGV.SelectedRows[0].Cells[2].Value.ToString();
            StageCb.SelectedItem = StResultsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ArabicTb.Text = StResultsDGV.SelectedRows[0].Cells[4].Value.ToString();
            EnglishTb.Text = StResultsDGV.SelectedRows[0].Cells[5].Value.ToString();
            MathTb.Text = StResultsDGV.SelectedRows[0].Cells[6].Value.ToString();
            ScienceTb.Text = StResultsDGV.SelectedRows[0].Cells[7].Value.ToString();
            ResalaTb.Text = StResultsDGV.SelectedRows[0].Cells[8].Value.ToString();
            QuaranTb.Text = StResultsDGV.SelectedRows[0].Cells[9].Value.ToString();
            ActivitiesTb.Text = StResultsDGV.SelectedRows[0].Cells[10].Value.ToString();
            GeographTb.Text = StResultsDGV.SelectedRows[0].Cells[11].Value.ToString();
            RelagionTb.Text = StResultsDGV.SelectedRows[0].Cells[12].Value.ToString();
            NoorBayanTb.Text = StResultsDGV.SelectedRows[0].Cells[13].Value.ToString();
            DiscoverTb.Text = StResultsDGV.SelectedRows[0].Cells[14].Value.ToString();
            TechnologyTb.Text = StResultsDGV.SelectedRows[0].Cells[15].Value.ToString();
            TanmyaTb.Text = StResultsDGV.SelectedRows[0].Cells[16].Value.ToString();
            estqbalTb.Text = StResultsDGV.SelectedRows[0].Cells[17].Value.ToString();

            _key = StNameTb.Text == "" ? 0 : Convert.ToInt32(StResultsDGV.SelectedRows[0].Cells[0].Value.ToString());
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            repo._db.conn.Close();
            if (_key == 0)
            {
                _ = MessageBox.Show("اختر الطالب");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from ResultTbl where ResId=@rsid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@rsid", _key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم حذف الطالب ");
                    repo._db.conn.Close();
                    DisplayResults();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                    repo._db.conn.Close();
                }
            }
        }

        private void StResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.ResultTbl' table. You can move, or remove it, as needed.
            _ = resultTblTableAdapter.Fill(schoolDBDataSet1.ResultTbl);
            // TODO: This line of code loads data into the 'schoolDBDataSet.ResultTbl' table. You can move, or remove it, as needed.
            //this.resultTblTableAdapter.Fill(this.schoolDBDataSet.ResultTbl);

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from ResultTbl where StName like'" + searchtxt.Text + "%'";
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            StResultsDGV.DataSource = dt;
            repo._db.conn.Close();
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
