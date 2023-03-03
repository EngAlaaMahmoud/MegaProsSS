using System;
using System.Windows.Forms;
using MainMenu = SchoolSystemERp.MainMenu;
namespace SchoolSystemERP.Screens.Exams
{
    public partial class MainRsMenue : Form
    {
        public MainRsMenue()
        {
            InitializeComponent();
        }
        #region Goto main and exit
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            Hide();
        }
        #endregion

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Stage1Rs sr1 = new Stage1Rs();
            sr1.Show();
            Hide();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Stage2Rs sr2 = new Stage2Rs();
            sr2.Show();
            Hide();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Stage3Rs sr3 = new Stage3Rs();
            sr3.Show();
            Hide();
        }
       
    }
}
