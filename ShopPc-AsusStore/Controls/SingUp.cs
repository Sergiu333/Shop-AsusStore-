using System;
using System.Windows.Forms;

namespace ShopPc_AsusStore.Controls
{
    public partial class SingUp : UserControl
    {
        public SingUp()
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SingIn g = new SingIn();
            adduserControl(g);
        }
    }
}