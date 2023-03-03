using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class AttendenceSt : Form
    {
        #region vars
        private int _key = 0;
        private static AttendenceSt frm;
        private readonly GenericRepository repo = new GenericRepository();
        #endregion
        #region Frm Helper
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static AttendenceSt GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new AttendenceSt();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            StIdCb.SelectedIndex = -1;
            StageCb.SelectedIndex = -1;
            StNameTb.Text = "";
        }
        #endregion
        #region Ctors
        public AttendenceSt()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            repo.DisplayAttendance(AttListDGV);
            repo.FillStId(StIdCb);
        }
        ~AttendenceSt()
        {
            Dispose();
        }
        #endregion
        #region Go Home &exit
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
        #endregion
        #region Add
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
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTbl(StId,StName,AttStStage,AttDate,AttStatus)values(@StId,@StName,@AtStStage,@Date,@Status)", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    _ = cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@AtStStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Date", AttDatePicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تسجيل الغياب");
                    repo._db.conn.Close();
                    repo.DisplayAttendance(AttListDGV);
                    Reset();
                    repo._db.conn.Close();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region Update
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                _ = MessageBox.Show("برجاء اختيار اسم الطالب");
            }
            else
            {
                try
                {
                    if (repo._db.conn.State == ConnectionState.Closed)
                    {
                        repo._db.conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Update  AttendanceTbl set StId=@StId,StName=@StName,AttStStage=@StStage,AttDate=@Date,AttStatus=@Status where AttNum=@ANum", repo._db.conn);
                    _ = cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    _ = cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    _ = cmd.Parameters.AddWithValue("@StStage", StageCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@Date", AttDatePicker.Value.Date);
                    _ = cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    _ = cmd.Parameters.AddWithValue("@ANum", _key);
                    _ = cmd.ExecuteNonQuery();
                    _ = MessageBox.Show("تم تعديل  الغياب");
                    repo._db.conn.Close();
                    repo.DisplayAttendance(AttListDGV);
                    Reset();

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region search
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            repo.SerachST("AttendanceTbl", AttListDGV, searchtxt.Text);
        }
        #endregion
        #region Frm Load
        private void Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet5.AttendanceTbl' table. You can move, or remove it, as needed.
            _ = attendanceTblTableAdapter2.Fill(schoolDBDataSet5.AttendanceTbl);
        }
        #endregion
        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            repo.GetStuName(StIdCb, StageCb, StNameTb);
        }
        private void AttListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StIdCb.SelectedValue = AttListDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = AttListDGV.SelectedRows[0].Cells[2].Value.ToString();
            StageCb.SelectedItem = AttListDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttDatePicker.Text = AttListDGV.SelectedRows[0].Cells[4].Value.ToString();
            AttStatusCb.SelectedItem = AttListDGV.SelectedRows[0].Cells[5].Value.ToString();
            _key = StNameTb.Text == "" ? 0 : Convert.ToInt32(AttListDGV.SelectedRows[0].Cells[0].Value.ToString());
        }
        //reset form
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
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
