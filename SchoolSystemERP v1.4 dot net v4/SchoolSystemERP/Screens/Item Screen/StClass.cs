using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MainMenu = SchoolSystemERp.MainMenu;
namespace SchoolSystemERP
{
    public partial class StClass : Form
    {
        #region vars
        private static StClass frm;
        private readonly GenericRepository repo = new GenericRepository();
        #endregion
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static StClass GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new StClass();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public StClass()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            Reset();
        }
        ~StClass()
        {
            Dispose();
        }
        private void DisplayStudents()
        {

            //repo.SearchStage("StudentTbl", StageDgv, stageTb.Text);
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select  StName,StGen,StDOB,StClass,StMobile,StAdd from StudentTbl where StClass=@StClss ", repo._db.conn);
            _ = cmd.Parameters.AddWithValue("@StClss", stageTb.Text);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = sd.Fill(dt);
            StageDgv.DataSource = dt;
            repo._db.conn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void StClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.StudentTbl' table. You can move, or remove it, as needed.
            _ = studentTblTableAdapter.Fill(schoolDBDataSet1.StudentTbl);
            DisplayStudents();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        #region print
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            _ = printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(StageDgv.Width, StageDgv.Height);
            StageDgv.DrawToBitmap(bmp, new Rectangle(0, 0, StageDgv.Width, StageDgv.Height));
            e.Graphics.DrawImage(bmp, 0, 0, StageDgv.Width, StageDgv.Height);
        }
        #endregion
        public void Reset()
        {
            ClassCb.SelectedValue = 1;
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
