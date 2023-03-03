using SchoolSystemERP.Repository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SchoolSystemERP
{
    public class GenericRepository :IGenericRepository
    {
        #region Vars
        public MyConnection _db = new MyConnection();
        #endregion
        #region Display
        public void DisplayAllq(string table, DataGridView gridView)
        {
            _ = new DataTable();
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            string query = "select * from " + table;
            SqlDataAdapter adapter = new SqlDataAdapter(query, _db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            gridView.DataSource = ds.Tables[0];
            _db.conn.Close();
        }
        public void DisplayFees(DataGridView dgv)
        {
            _ = new DataTable();
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            string query = "select * from FeesTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            _db.conn.Close();
        }
        public void DisplayStudents(DataGridView dgvst)
        {
            _ = new DataTable();
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            string query = "select * from StudentTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            dgvst.DataSource = ds.Tables[0];
            _db.conn.Close();
        }
        public void DisplayAttendance(DataGridView dgv)
        {
            _ = new DataTable();
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            string query = "select * from AttendanceTbl ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _db.conn);
            _ = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            _ = adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            _db.conn.Close();
        }
        #endregion
        #region Search
        public void SerachST(string table, DataGridView gridView, string searchtxt)
        {
            string query = "select * from " + table + " where StName like'" + searchtxt + "%'";
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, _db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            gridView.DataSource = dt;
            _db.conn.Close();
        }
        public void SearchStage(string table, DataGridView gridView, string searchtxt)
        {
            string query = "select StName,StGen,StDOB,StClass,StMobile,StAdd from " + table + " where StClass like'" + searchtxt + "%'";
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, _db.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _ = adapter.Fill(dt);
            gridView.DataSource = dt;
            _db.conn.Close();
        }
        #endregion
        #region Fill
        public void FillStId(ComboBox cb)
        {
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", _db.conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            _ = dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            cb.ValueMember = "StId";
            cb.DataSource = dt;
            _db.conn.Close();
        }
        public void GetStuName(ComboBox Idcb,ComboBox stgCb,TextBox NameTb)
        {
            if (_db.conn.State == ConnectionState.Closed)
            {
                _db.conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SId", _db.conn);
            _ = cmd.Parameters.AddWithValue("@SId", Idcb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            _ = sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NameTb.Text = dr["StName"].ToString();
                stgCb.SelectedItem = dr["StClass"].ToString();

            }
            _db.conn.Close();
        }
        #endregion
     
    }
}
