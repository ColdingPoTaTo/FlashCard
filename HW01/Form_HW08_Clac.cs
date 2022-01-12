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
    public partial class Form_HW08_Clac : Form
    {
        public Form_HW08_Clac()
        {
            InitializeComponent();
        }
        double Num1, Num2, Answer;
        string isNumber;
        //GetNumber取得User輸入的數字
        public void GetNumber()
        {
            isNumber = "no";
            try
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);
                isNumber = "yes";
            }
            catch(System.FormatException)
            {
                MessageBox.Show("請輸入數值。");                
            }
            
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            GetNumber();
            Answer = Num1 - Num2;
            if(isNumber == "yes")
            {
                labelTheAns.Text = Convert.ToString(Answer);
            }            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            GetNumber();
            Answer = Num1 * Num2;
            if (isNumber == "yes")
            {
                labelTheAns.Text = Convert.ToString(Answer);
            }
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            GetNumber();
            Answer = Num1 / Num2;
            if (isNumber == "yes")
            {
                labelTheAns.Text = Convert.ToString(Answer);
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            GetNumber();
            Answer = Num1 + Num2;
            if (isNumber == "yes")
            {
                labelTheAns.Text = Convert.ToString(Answer);
            }
        }
    }
}
