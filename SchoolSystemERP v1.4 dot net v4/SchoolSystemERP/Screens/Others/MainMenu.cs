using SchoolSystemERP;
using SchoolSystemERP.Screens.Exams;
using System;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class MainMenu : Form
    {
        private static MainMenu frm;

        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static MainMenu GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new MainMenu();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public MainMenu()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }
        ~MainMenu()
        {
            Dispose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Teachers Teachers = new Teachers();
            Teachers.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Students Students = new Students();
            Students.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fees Fees = new Fees();
            Fees.Show();
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SchoolSystemERp.Events events = new SchoolSystemERp.Events();
            events.Show();
            Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DashBoard DashBoard = new DashBoard();
            DashBoard.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AttendenceSt att = new AttendenceSt();
            att.Show();
            Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MainRsMenue rs = new MainRsMenue();
            rs.Show();
            Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (MyConnection.type == "U")
            {
                pictureBox7.Enabled = false;
                panel7.Enabled = false;
                pictureBox1.Enabled = false;
                panel3.Enabled = false;
                pictureBox4.Enabled = false;
                panel4.Enabled = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            StClass cc = new StClass();
            cc.Show();
            Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            OutGo o = new OutGo();
            Hide();
            o.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            AttendenceTecher aa = new AttendenceTecher();
            Hide();
            aa.Show();
        }
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
