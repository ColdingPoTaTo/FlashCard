using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class Form_HW11_ScreenSaver : Form
    {
        public Form_HW11_ScreenSaver()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.pictureBox1.Image = Properties.Resources.IU;
        }
        Point mouseXY;

        private void AnyMoving(object sender, MouseEventArgs e)
        {            
            if (mouseXY.IsEmpty)
            {
                mouseXY = e.Location;
            }
            else if (e.Location.X - mouseXY.X >5 || e.Location.Y - mouseXY.Y > 5)
            {
                this.Close();
            }            
        }        

        //Get screen resolution
        Rectangle res = Screen.PrimaryScreen.Bounds; 
        int SpeedY = 5, SpeedX = 5;

        private void moveTimerEvent(object sender, EventArgs e)
        {
            this.pictureBox1.Left += SpeedY;
            this.pictureBox1.Top += SpeedX;
            if (pictureBox1.Right >= res.Right || pictureBox1.Left <=0 )
            {
                SpeedY = SpeedY * -1;
            }
            else if (pictureBox1.Bottom >= res.Bottom || pictureBox1.Top <= 0)
            {
                SpeedX = SpeedX * -1;
            }            
        }
    }
}
