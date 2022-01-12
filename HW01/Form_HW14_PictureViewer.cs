using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class Form_HW14_PictureViewer : Form
    {
        public Form_HW14_PictureViewer()
        {
            InitializeComponent();           
        }

        private void picClick(object sender, EventArgs e)
        {
            Form_HW14_PopViewer PV = new Form_HW14_PopViewer();
            PictureBox clickPic = (PictureBox)sender;
            if (clickPic != null)
            {
                PV.BackgroundImage = clickPic.Image;
                PV.Show();
            }
        }

    }
}
