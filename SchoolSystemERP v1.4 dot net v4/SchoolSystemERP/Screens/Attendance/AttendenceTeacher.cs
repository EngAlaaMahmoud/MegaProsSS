using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class AttendenceTecher : Form
    {
        private static AttendenceTecher frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static AttendenceTecher GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new AttendenceTecher();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        ~AttendenceTecher()
        {
            Dispose();
        }
        public AttendenceTecher()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            DisplayAttendance();
            FillStId();
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
        private void FillStId()
        {
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select TId from TeacherTbl", repo._db.conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            _ = dt.Columns.Add("TId", typeof(int));
            dt.Load(rdr);
            StIdCb.ValueMember = "TId";
            StIdCb.DataSource = dt;
            repo._db.conn.Close();
        }
        private void GetStuName()
        {
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from TeacherTbl where TId=@Id", repo._db.conn);
            _ = cmd.Parameters.AddWithValue("@Id", StIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            _ = sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["TName"].ToString();
            }
            repo._db.conn.Close();
        }
        #region the old connection
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion
        private void DisplayAttendance()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from AttndTcherTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            AttListDGV.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }
        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            StIdCb.SelectedIndex = -1;
            StNameTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                _ = MessageBox.Show("برجاء ادخال اسم المستخدم");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into AttndTcherTbl(AttStId,AttStName,AttDate,AttStatus)values(@StId,@StName,@Date,@Status)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    _ = cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Date", AttDatePicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تسجيل الغياب");
                    repo._db.conn.Close();
                    DisplayAttendance();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStuName();
        }

        private int key = 0;
        private void AttListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StIdCb.SelectedValue = AttListDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = AttListDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttDatePicker.Text = AttListDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttStatusCb.SelectedItem = AttListDGV.SelectedRows[0].Cells[4].Value.ToString();
            key = StNameTb.Text == "" ? 0 : Convert.ToInt32(AttListDGV.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                _ = MessageBox.Show("برجاء اختيار اسم المدرس");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Update  AttndTcherTbl set AttStId=@StId,AttStName=@StName,AttDate=@Date,AttStatus=@Status where AttNum=@ANum ", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    _ = cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Date", AttDatePicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@ANum", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل بيانات الغياب");
                    repo._db.conn.Close();
                    DisplayAttendance();
                    Reset();

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        private void Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.AttndTcherTbl' table. You can move, or remove it, as needed.
            _ = attndTcherTblTableAdapter.Fill(schoolDBDataSet.AttndTcherTbl);
            // TODO: This line of code loads data into the 'schoolDBDataSet1.AttendanceTbl' table. You can move, or remove it, as needed.
            //_ = attendanceTblTableAdapter.Fill(schoolDBDataSet1.AttendanceTbl);

        }
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from AttndTcherTbl where AttStName like'" + searchtxt.Text + "%'";
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            AttListDGV.DataSource = dt;
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
