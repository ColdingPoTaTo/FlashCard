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
    public partial class Form_HW13_DrawPaint : Form
    {
        Graphics graph;
        int x = -1, y = -1;
        bool moving = false;
        Pen pen;

        public Form_HW13_DrawPaint()
        {
            InitializeComponent();
            pen = new Pen(Color.Black,1); //建立畫筆
            graph = CreateGraphics();  //在panelDraw上建立畫圖區            
        }

        

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x!=-1 && y != -1)
            {
                graph.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
        //按下顏色按鈕後，user選取顏色，picBox=顏色，pen.color=picbox.color
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picBoxColor.BackColor = colorDialog1.Color;
            pen.Color = picBoxColor.BackColor;
        }

        //變更pen大小
        private void trackBarPenSize_ValueChanged(object sender, EventArgs e)
        {
            labSize.Text = Convert.ToString(trackBarPenSize.Value);
            pen.Width = trackBarPenSize.Value;
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }
    }
}
