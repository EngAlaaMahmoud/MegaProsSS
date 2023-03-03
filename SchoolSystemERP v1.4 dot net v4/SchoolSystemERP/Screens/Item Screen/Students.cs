using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SchoolSystemERp
{
    public partial class Students : Form
    {
        private static Students frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Students GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Students();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Students()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            DisplayStudents();
        }
        ~Students()
        {
            Dispose();
        }
        #region old connection way
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");
        //  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion
        private void DisplayStudents()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from StudentTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesBookTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1 || MobileTb.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StMobile,StAdd,StFeesBook,StFeesCloth,StFeesBus,StFees,StFeesM1,StFeesM2,StFeesM3,StFeesM4,StFeesM5)values(@Sname,@SGen,@SDob,@SClass,@SMobile,@SAdd,@SFeesBook,@FeesCloth,@StFeesBus,@SFees,@sFeesM1,@sFeesM2,@sFeesM3,@sFeesM4,@sFeesM5)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@SDOB", DOBpicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@SMobile", MobileTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SFeesBook", FeesBookTb.Text);
                    _ = cmd.Parameters.AddWithValue("@FeesCloth", FeesClothTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StFeesBus", FeesBusTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM1", FeesM1Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM2", FeesM2Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM3", FeesM3Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM4", FeesM4Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM5", FeesM5Tb.Text);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة الطالب");
                    repo._db.conn.Close();
                    DisplayStudents();
                    Reset();
                    repo._db.conn.Close();
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
        private void Reset()
        {
            key = 0;
            StNameTb.Text = "";
            StGenCb.SelectedIndex = -1;
            AddressTb.Text = "";
            FeesBookTb.Text = "0";
            MobileTb.Text = "";
            ClassCb.SelectedIndex = -1;
            FeesM1Tb.Text = "0";
            FeesM2Tb.Text = "0";
            FeesM3Tb.Text = "0";
            FeesM4Tb.Text = "0";
            FeesM5Tb.Text = "0";

        }

        private int key = 0;
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StGenCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DOBpicker.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ClassCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            MobileTb.Text = StudentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AddressTb.Text = StudentsDGV.SelectedRows[0].Cells[6].Value.ToString();
            FeesBookTb.Text = StudentsDGV.SelectedRows[0].Cells[7].Value.ToString();
            FeesClothTb.Text = StudentsDGV.SelectedRows[0].Cells[8].Value.ToString();
            FeesBusTb.Text = StudentsDGV.SelectedRows[0].Cells[9].Value.ToString();
            FeesTb.Text = StudentsDGV.SelectedRows[0].Cells[10].Value.ToString();
            FeesM1Tb.Text = StudentsDGV.SelectedRows[0].Cells[11].Value.ToString();
            FeesM2Tb.Text = StudentsDGV.SelectedRows[0].Cells[12].Value.ToString();
            FeesM3Tb.Text = StudentsDGV.SelectedRows[0].Cells[13].Value.ToString();
            FeesM4Tb.Text = StudentsDGV.SelectedRows[0].Cells[14].Value.ToString();
            FeesM5Tb.Text = StudentsDGV.SelectedRows[0].Cells[15].Value.ToString();
            key = StNameTb.Text == "" ? 0 : Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                _ = MessageBox.Show("اختر الطالب");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("هل تريد حذف الطالب", "حذف الطالب", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (repo._db.conn.State == ConnectionState.Closed)
                        {
                            repo._db.conn.Open();
                        }
                        SqlCommand cmd = new SqlCommand("delete from StudentTbl where StId=@StKey", repo._db.conn);
                        _ = cmd.Parameters.AddWithValue("@StKey", key);
                        _ = cmd.ExecuteNonQuery();
                        _ = MessageBox.Show("تم حذف الطالب ");
                        repo._db.conn.Close();
                        DisplayStudents();
                        Reset();
                        repo._db.conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesBookTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1 || MobileTb.Text == "")
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
                    SqlCommand cmd = new SqlCommand("Update  StudentTbl set StName=@Sname,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StMobile=@SMobile,StAdd=@SAdd,StFeesBook=@SFeesBook,StFeesCloth=@FeesCloth,StFeesBus=@StFeesBus,StFees=@SFees,StFeesM1=@sFeesM1,StFeesM2=@sFeesM2,StFeesM3=@sFeesM3,StFeesM4=@sFeesM4,StFeesM5=@sFeesM5 where StId=@Sid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@SDOB", DOBpicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@SMobile", MobileTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SFeesBook", FeesBookTb.Text);
                    _ = cmd.Parameters.AddWithValue("@FeesCloth", FeesClothTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StFeesBus", FeesBusTb.Text);
                    _ = cmd.Parameters.AddWithValue("@SFees", FeesBookTb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM1", FeesM1Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM2", FeesM2Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM3", FeesM3Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM4", FeesM4Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@sFeesM5", FeesM5Tb.Text);
                    _ = cmd.Parameters.AddWithValue("@Sid", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل بيانات الطالب");
                    repo._db.conn.Close();
                    DisplayStudents();
                    Reset();
                    repo._db.conn.Close();
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

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.StudentTbl' table. You can move, or remove it, as needed.
            _ = studentTblTableAdapter.Fill(schoolDBDataSet1.StudentTbl);

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from StudentTbl where StName like'" + searchtxt.Text + "%'";
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            StudentsDGV.DataSource = dt;
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
