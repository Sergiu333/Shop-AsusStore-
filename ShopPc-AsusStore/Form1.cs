using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopPc_AsusStore.Controls;

namespace ShopPc_AsusStore
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SingIn g = new SingIn();
            adduserControl(g);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home g = new Home();
            adduserControl(g);  
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }   
        }
        
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}