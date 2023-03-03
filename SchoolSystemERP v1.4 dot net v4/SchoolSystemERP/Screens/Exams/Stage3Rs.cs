using SchoolSystemERP.Screens.Exams;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolSystemERP
{
    //نتيجة المراحل الاخيره
    public partial class Stage3Rs : Form
    {
        #region vars
        private readonly GenericRepository repo = new GenericRepository();
        private static Stage3Rs frm;
        private int _key = 0;
        #endregion
        #region frm helper
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Stage3Rs GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Stage3Rs();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        #endregion
        #region Ctors
        public Stage3Rs()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            repo.DisplayAllq("Stage3RSTbl", StResultsDGV);
            repo.FillStId(StdIdCb);
        }
        ~Stage3Rs()
        {
            Dispose();
        }
        #endregion
        #region HelpMethods
        private void Reset()
        {
            StNameTb.Text = "";
            EnglishTb.Text = "0";
            MathTb.Text = "0";
            ArabicTb.Text = "0";
            QuaranTb.Text = "0";
            ScienceTb.Text = "0";
            GeographTb.Text = "0";
            NoorBayanTb.Text = "0";
        }
        #endregion
        #region Goto main and exit
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainRsMenue mainMenurs = new MainRsMenue();
            mainMenurs.Show();
            Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            repo.GetStuName(StdIdCb, StageCb, StNameTb);
        }
        private void StResultsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdIdCb.SelectedItem = StResultsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = StResultsDGV.SelectedRows[0].Cells[2].Value.ToString();
            StageCb.SelectedItem = StResultsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ArabicTb.Text = StResultsDGV.SelectedRows[0].Cells[4].Value.ToString();
            NoorBayanTb.Text = StResultsDGV.SelectedRows[0].Cells[5].Value.ToString();
            MathTb.Text = StResultsDGV.SelectedRows[0].Cells[6].Value.ToString();
            EnglishTb.Text = StResultsDGV.SelectedRows[0].Cells[7].Value.ToString();
            ScienceTb.Text = StResultsDGV.SelectedRows[0].Cells[8].Value.ToString();
            GeographTb.Text = StResultsDGV.SelectedRows[0].Cells[9].Value.ToString();
            RelgionTb.Text = StResultsDGV.SelectedRows[0].Cells[10].Value.ToString();
            QuaranTb.Text = StResultsDGV.SelectedRows[0].Cells[11].Value.ToString();
            //QuaranTb.Text = StResultsDGV.SelectedRows[0].Cells[12].Value.ToString();
            //Dpicker.Value = DateTime(StResultsDGV.SelectedRows[0].Cells[13].Value);
            _key = StNameTb.Text == "" ? 0 : Convert.ToInt32(StResultsDGV.SelectedRows[0].Cells[0].Value.ToString());
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void StResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet6.Stage3RSTbl' table. You can move, or remove it, as needed.
            _ = stage3RSTblTableAdapter.Fill(schoolDBDataSet6.Stage3RSTbl);
            // TODO: This line of code loads data into the 'schoolDBDataSet1.ResultTbl' table. You can move, or remove it, as needed.
            _ = resultTblTableAdapter.Fill(schoolDBDataSet1.ResultTbl);
            // TODO: This line of code loads data into the 'schoolDBDataSet.ResultTbl' table. You can move, or remove it, as needed.
            //this.resultTblTableAdapter.Fill(this.schoolDBDataSet.ResultTbl);

        }
        #region Add
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StageCb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال  الماده   ");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into Stage3RSTbl(StId,StName,StStage,Arabic,NoorBayan,Math,English,Science,geographic,Relgion,Quaran,RMonth)" +
                        "values(@StId,@Sname,@StStage,@Arabic,@NoorBayan,@Math,@English,@Science,@geographic,@Relgion,@Quaran,@RMonth)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StdIdCb.SelectedValue);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Arabic", ArabicTb.Text);
                    _ = cmd.Parameters.AddWithValue("@NoorBayan", NoorBayanTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Math", MathTb.Text);
                    _ = cmd.Parameters.AddWithValue("@English", EnglishTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Science", ScienceTb.Text);
                    _ = cmd.Parameters.AddWithValue("@geographic", GeographTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Relgion", RelgionTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Quaran", QuaranTb.Text);
                    _ = cmd.Parameters.AddWithValue("@RMonth", Dpicker.Value.Date);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة نتيجة الطالب");
                    repo._db.conn.Close();
                    Reset();
                    repo.DisplayAllq("Stage3RSTbl", StResultsDGV);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region Print
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
        #endregion
        #region Update
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
                    SqlCommand cmd = new SqlCommand("update  Stage3RSTbl set StId=@StId,StName=@Sname,StStage=@StStage,Arabic=@Arabic,NoorBayan=@NoorBayan,Math=@Math,English=@English," +
                        "Science=@Science,geographic=@geographic,Relgion=@Relgion,Quaran=@Quaran,RMonth=@RMonth where ResId=@rsid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StdIdCb.SelectedValue);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Arabic", ArabicTb.Text);
                    _ = cmd.Parameters.AddWithValue("@NoorBayan", NoorBayanTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Math", MathTb.Text);
                    _ = cmd.Parameters.AddWithValue("@English", EnglishTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Science", ScienceTb.Text);
                    _ = cmd.Parameters.AddWithValue("@geographic", GeographTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Relgion", RelgionTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Quaran", QuaranTb.Text);
                    _ = cmd.Parameters.AddWithValue("@RMonth", Dpicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("rsid", _key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل نتيجة الطالب");
                    repo._db.conn.Close();
                    Reset();
                    repo.DisplayAllq("Stage3RSTbl", StResultsDGV);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }
        #endregion
        #region Delete
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
                    SqlCommand cmd = new SqlCommand("delete from Stage3RSTbl where ResId=@rsid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@rsid", _key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم حذف الطالب ");
                    repo._db.conn.Close();
                    repo.DisplayAllq("Stage3RSTbl", StResultsDGV);
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
        #endregion
        #region SearchByName
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            repo.SerachST("Stage3RSTbl", StResultsDGV, searchtxt.Text);
        }
        #endregion
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
