using System;
using System.Windows.Forms;

namespace ShopPc_AsusStore.Controls
{
    public partial class SingIn : UserControl
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SingUp g = new SingUp();
            adduserControl(g);
        }
    }
}