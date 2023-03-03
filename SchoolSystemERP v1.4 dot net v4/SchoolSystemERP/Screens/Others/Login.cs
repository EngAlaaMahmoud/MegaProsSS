using SchoolSystemERP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
namespace SchoolSystemERp
{
    public partial class Login : Form
    {
        private static Login frm;
        private readonly GenericRepository repo = new GenericRepository();
        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Login GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Login();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Login()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }
        ~Login()
        {
            Dispose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        //class user
        // {
        //     public string Name { get; set; }
        //     public string Password { get; set; }    
        // }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            #region old way login
            //user user = new user();
            //user.Name = UnameTb.Text;
            //user.Password = PasswordTb.Text;    
            //if (user.Name == "" || user.Password == "")
            //{
            //    MessageBox.Show("برجاء ادخال اسم المستخدم والرقم السري");
            //}
            //else if (user.Name == "admin" && user.Password == "password")
            //{
            //    MainMenu mainMenu = new MainMenu();
            //    mainMenu.Show();
            //    this.Hide();
            //}
            //else if (user.Name == "user" && user.Password == "123")
            //{
            //    MainMenu mainMenu = new MainMenu();
            //    mainMenu.Show();
            //    DashBoard d = new DashBoard();
            //    //d.Equals(view);
            //    this.Hide();
            //}
            //   catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //else
            //{
            //    MessageBox.Show("برجاء ادخال اسم المستخدم والرقم السري بطريقه صحيحه او الرجوع الي الاداره");
            //    UnameTb.Text = "";
            //    PasswordTb.Text = "";
            //}
            #endregion
            try
            {
                SqlCommand cmd = new SqlCommand("SP_role_login", repo._db.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                repo._db.conn.Open();
                _ = cmd.Parameters.AddWithValue("@uname", UnameTb.Text);
                _ = cmd.Parameters.AddWithValue("@upass", PasswordTb.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    _ = rd.Read();
                    if (rd[4].ToString() == "admin")
                    {
                        MyConnection.type = "A";
                    }
                    else if (rd[4].ToString() == "user")
                    {
                        MyConnection.type = "U";

                    }
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    Hide();
                }
                else
                {
                    _ = MessageBox.Show("برجاء ادخال اسم المستخدم والرقم السري بطريقه صحيحه او الرجوع الي الاداره");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                repo._db.conn.Close();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }

        }

        private void CheckBxShowPs_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTb.PasswordChar = CheckBxShowPs.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Splash s = new Splash();
            s.Show();
            Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = Process.Start("https://web.facebook.com/profile.php?id=100063604824715");
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
