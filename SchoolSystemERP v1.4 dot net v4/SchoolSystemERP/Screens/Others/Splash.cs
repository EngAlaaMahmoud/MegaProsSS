using System;
using System.Windows.Forms;

namespace SchoolSystemERp
{
    public partial class Splash : Form
    {
        private static Splash frm;

        private static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Splash GetAttendenceSt
        {
            get
            {
                if (frm == null)
                {
                    frm = new Splash();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Splash()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }
        ~Splash()
        {
            Dispose();
        }
        private int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MYprogressBar.Value = startpoint;
            Percntage.Text = startpoint + "%";
            if (MYprogressBar.Value == 100)
            {
                MYprogressBar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                Hide();
                login.Show();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}