using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class Events : Form
    {
        private static Events frm;
        private readonly GenericRepository repo = new GenericRepository();

        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Events GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Events();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Events()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            DisplayEvents();
        }
        ~Events()
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
        #region Old connection way
        //SqlConnection conn = new SqlConnection(@"Data Source=ASH-PC\SQLEXPRESS;Initial Catalog=SchoolDb;User Id=sa;Password=123;");
        // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dinag\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        #endregion
        private void DisplayEvents()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from EventsTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            EventDGV.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }
        private void Reset()
        {
            EDescTb.Text = "";
            EDurationTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال البيانات اللازمه للاضافه");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into EventsTbl(EDesc,EDate,EDuration)values(@EDesc,@EDate,@EDuration)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@EDesc", EDescTb.Text);
                    _ = cmd.Parameters.AddWithValue("@EDate", EDate.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@EDuration", EDurationTb.Text);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم الاضافه");
                    repo._db.conn.Close();
                    DisplayEvents();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }

        }

        private int key = 0;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                _ = MessageBox.Show("اختر المناسبه");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from EventsTbl where EId=@EKey", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@EKey", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم الحذف");
                    repo._db.conn.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }

        private void EventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EDescTb.Text = EventDGV.SelectedRows[0].Cells[1].Value.ToString();
            EDate.Text = EventDGV.SelectedRows[0].Cells[2].Value.ToString();
            EDurationTb.Text = EventDGV.SelectedRows[0].Cells[3].Value.ToString();

            key = EDescTb.Text == "" ? 0 : Convert.ToInt32(EventDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                _ = MessageBox.Show("برجاء ادخال البيانات اللازمه للتعديل");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Update  EventsTbl set EDesc=@desc,EDate=@Date,EDuration=@Duration where EId=@Eid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@desc", EDescTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Date", EDate.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@Duration", EDurationTb.Text);
                    _ = cmd.Parameters.AddWithValue("@Eid", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم التعديل");
                    repo._db.conn.Close();
                    DisplayEvents();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.EventsTbl' table. You can move, or remove it, as needed.
            _ = eventsTblTableAdapter.Fill(schoolDBDataSet1.EventsTbl);

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

