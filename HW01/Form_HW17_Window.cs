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
    public partial class Form_HW17_Window : Form
    {
        public Form_HW17_Window()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btn_HW01_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            FormHW01 HW = new FormHW01() {TopLevel = false };//指示子窗體非頂級窗體
            this.panelFormShow.Controls.Add(HW);//將子窗體載入panel
            HW.Show();
        }

        private void btn_HW02_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW02_Loan HW = new Form_HW02_Loan() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW03_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW03_POS HW = new Form_HW03_POS() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW04_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW04_StudentStruct HW = new Form_HW04_StudentStruct() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW05_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW05_StudentGrade HW = new Form_HW05_StudentGrade() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW06_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW06_StudentList HW = new Form_HW06_StudentList() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show(); 
        }

        private void btn_HW08_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW08_Clac HW = new Form_HW08_Clac() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show(); 
        }

        private void btn_HW10_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW10_XOGame HW = new Form_HW10_XOGame() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
            HW.Focus();
        }

        private void btn_HW11_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW11_ScreenSaver HW = new Form_HW11_ScreenSaver() { TopLevel = true };
            HW.Show();
        }

        private void btn_HW15_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW15_Guess HW = new Form_HW15_Guess() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
            HW.Focus();
        }

        private void btn_HW13_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW13_DrawPaint HW = new Form_HW13_DrawPaint() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW14_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW14_PictureViewer HW = new Form_HW14_PictureViewer() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_HW12_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_HW12_Notepad HW = new Form_HW12_Notepad() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
        }

        private void btn_FlappyBird_Click(object sender, EventArgs e)
        {
            this.panelFormShow.Controls.Clear();
            Form_Game_FlappyBird HW = new Form_Game_FlappyBird() { TopLevel = false };
            this.panelFormShow.Controls.Add(HW);
            HW.Show();
            HW.Focus();
        }
    }
}
