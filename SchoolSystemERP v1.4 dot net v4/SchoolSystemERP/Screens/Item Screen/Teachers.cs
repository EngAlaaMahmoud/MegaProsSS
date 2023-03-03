using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class Teachers : Form
    {
        private static Teachers frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Teachers GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Teachers();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        ~Teachers()
        {
            Dispose();
        }
        public Teachers()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            DisplayTeachers();
        }
        #region old connection way
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion
        private void DisplayTeachers()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from TeacherTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }
        private void Reset()
        {
            key = 0;
            TNameTb.Text = "";
            TGenCb.SelectedIndex = -1;
            TAddTb.Text = "";
            TPhoneTb.Text = "";
            TSubjCb.SelectedIndex = -1;
            TSalaryTb.Text = "0";
        }

        private int key = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TSubjCb.SelectedIndex == -1 || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || TPhoneTb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال البيانات الناقصه");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(TName,TGen,TPhone,TSubject,TAdd,TDOB,TSalary)values(@Name,@Gen,@Phone,@Subject,@Add,@DOB,@TSalary)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@Name", TNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Gen", TGenCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Phone", TPhoneTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Subject", TSubjCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Add", TAddTb.Text);
                    _ = cmd.Parameters.AddWithValue("@DOB", DOB.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@TSalary", TSalaryTb.Text);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة المدرس");
                    repo._db.conn.Close();
                    DisplayTeachers();
                    Reset();

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNameTb.Text = TeachersDGV.SelectedRows[0].Cells[1].Value.ToString();
            TGenCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[2].Value.ToString();
            TPhoneTb.Text = TeachersDGV.SelectedRows[0].Cells[3].Value.ToString();
            TSubjCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[4].Value.ToString();
            TAddTb.Text = TeachersDGV.SelectedRows[0].Cells[5].Value.ToString();
            DOB.Text = TeachersDGV.SelectedRows[0].Cells[6].Value.ToString();
            TSalaryTb.Text = TeachersDGV.SelectedRows[0].Cells[7].Value.ToString();
            key = TNameTb.Text == "" ? 0 : Convert.ToInt32(TeachersDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                _ = MessageBox.Show("اختر المدرس");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from TeacherTbl where TId=@TKey", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@TKey", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم حذف بيانات المدرس");
                    repo._db.conn.Close();
                    DisplayTeachers();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || TSubjCb.SelectedIndex == -1 || TPhoneTb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال البيانات الناقصه");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Update  TeacherTbl set TName=@Tname,TGen=@TGen,TPhone=@Tphone,TSubject=@Tsubject,TAdd=@TAdd,TDOB=@TDOB,TSalary=@TSalary where TId=@Techid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@TName", TNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    _ = cmd.Parameters.AddWithValue("@TSubject", TSubjCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    _ = cmd.Parameters.AddWithValue("@TDOB", DOB.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@TSalary", TSalaryTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Techid", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل بيانات المدرس");
                    repo._db.conn.Close();
                    DisplayTeachers();
                    Reset();

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();

        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.TeacherTbl' table. You can move, or remove it, as needed.
            _ = teacherTblTableAdapter.Fill(schoolDBDataSet1.TeacherTbl);

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from TeacherTbl where TName like'" + searchtxt.Text + "%'";
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            TeachersDGV.DataSource = dt;
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
