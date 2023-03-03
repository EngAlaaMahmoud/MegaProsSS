using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MainMenu = SchoolSystemERp.MainMenu;
namespace SchoolSystemERP
{
    public partial class OutGo : Form
    {
        private readonly GenericRepository repo = new GenericRepository();

        public OutGo()
        {
            InitializeComponent();
            DisplayOutGo();
        }
        ~OutGo()
        {
            Dispose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void outGoTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _ = Validate();
            outGoTblBindingSource.EndEdit();


        }

        private void OutGo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.OutGoTbl' table. You can move, or remove it, as needed.
            _ = outGoTblTableAdapter.Fill(schoolDBDataSet1.OutGoTbl);


        }
        private void DisplayOutGo()
        {
            _ = new DataTable();
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            string query = "select * from OutGoTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, repo._db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            dgvcost.DataSource = ds.Tables[0];
            repo._db.conn.Close();
        }
        private void Reset()
        {
            NameTb.Text = "";
            DecTb.Text = "";
            CostTb.Text = "";
            NotesTb.Text = "";
        }

        private int key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || datepicker1.Text == "" || DecTb.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into OutGoTbl(OutGoName,OutGoDate,OutGoDesc,OutGoCost,OutGoNote)values(@OutGoName,@OutGoDate,@OutGoDesc,@OutGoCost,@OutGoNote)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@OutGoName", NameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoDate", datepicker1.Value.ToString());
                    _ = cmd.Parameters.AddWithValue("@OutGoDesc", DecTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoCost", CostTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoNote", NotesTb.Text);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم اضافة التكاليف");
                    DisplayOutGo();
                    repo._db.conn.Close();
                    Reset();

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }
        }



        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || datepicker1.Text == "" || DecTb.Text == "")
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

                    SqlCommand cmd = new SqlCommand("Update  OutGoTbl set OutGoName=@OutGoName,OutGoDate=@OutGoDate,OutGoDesc=@OutGoDesc,OutGoCost=@OutGoCost,OutGoNote=@OutGoNote where OutGoId=@outid", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@OutGoName", NameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoDate", datepicker1.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@OutGoDesc", DecTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoCost", CostTb.Text);
                    _ = cmd.Parameters.AddWithValue("@OutGoNote", NotesTb.Text);
                    _ = cmd.Parameters.AddWithValue("@outid", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل بيانات  التكاليف");
                    DisplayOutGo();
                    repo._db.conn.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                _ = MessageBox.Show("اختر التكاليف");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from OutGoTbl where OutGoId=@TKey", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@TKey", key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم حذف بيانات التكاليف");
                    repo._db.conn.Close();
                    DisplayOutGo();
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvcost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = dgvcost.SelectedRows[0].Cells[1].Value.ToString();
            datepicker1.Text = dgvcost.SelectedRows[0].Cells[2].Value.ToString();
            DecTb.Text = dgvcost.SelectedRows[0].Cells[3].Value.ToString();
            CostTb.Text = dgvcost.SelectedRows[0].Cells[4].Value.ToString();
            NotesTb.Text = dgvcost.SelectedRows[0].Cells[5].Value.ToString();

            key = NameTb.Text == "" ? 0 : Convert.ToInt32(dgvcost.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            Hide();
            m.Show();

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from OutGoTbl where OutGoName like'" + searchtxt.Text + "%'";
            if (repo._db.conn.State == ConnectionState.Closed)
            {
                repo._db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, repo._db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            dgvcost.DataSource = dt;
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
