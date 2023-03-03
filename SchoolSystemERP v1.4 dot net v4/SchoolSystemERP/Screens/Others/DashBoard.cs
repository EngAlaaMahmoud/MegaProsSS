using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class DashBoard : Form
    {
        private static DashBoard frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static DashBoard GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new DashBoard();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        ~DashBoard()
        {
            Dispose();
        }
        public DashBoard()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region fill Method1
        private void CountStudents()
        {
            repo._db.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from StudentTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            repo._db.conn.Close();
        }
        private void CountTeachers()
        {
            repo._db.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from TeacherTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            TLbl.Text = dt.Rows[0][0].ToString();
            repo._db.conn.Close();
        }
        private void CountEvents()
        {
            repo._db.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*)  from EventsTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            ELbl.Text = dt.Rows[0][0].ToString();
            repo._db.conn.Close();
        }
        private void CountAmount()
        {
            repo._db.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select SUM(Amt) from FeesTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            AmountLbl.Text = dt.Rows[0][0].ToString();
            repo._db.conn.Close();
        }
        private void CountFees()
        {
            repo._db.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select SUM(StFeesTotal) from StudentTbl", repo._db.conn);
            DataTable dt = new DataTable();
            _ = sda.Fill(dt);
            FesLbl.Text = dt.Rows[0][0].ToString();
            repo._db.conn.Close();
        }
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MainMenu ob = new MainMenu();
            ob.Show();
            Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            CountStudents();
            CountTeachers();
            CountEvents();
            CountFees();
            CountAmount();
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
