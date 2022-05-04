using System;
using System.Windows.Forms;

namespace ShopPc_AsusStore.Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
             SingIn g = new SingIn();
                        adduserControl(g);  
        }
    }
}