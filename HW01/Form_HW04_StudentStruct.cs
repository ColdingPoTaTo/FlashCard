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
    public partial class Form_HW04_StudentStruct : Form
    {
        public Form_HW04_StudentStruct()
        {
            InitializeComponent();
        }

        int[] ScoreArray = new int[3];
        string MyName;

        private void btnSaveArray_Click(object sender, EventArgs e)
        {
            ScoreArray[0] = Convert.ToInt32(txtCH.Text);
            ScoreArray[1] = Convert.ToInt32(txtEN.Text);
            ScoreArray[2] = Convert.ToInt32(txtMath.Text);
            MyName = txtName.Text;
        }

        private void btnShowBest_Click(object sender, EventArgs e)
        {
            int maxValue = ScoreArray.Max();
            int minValue = ScoreArray.Min();            
            int maxSujectIndex = Array.IndexOf(ScoreArray, maxValue);
            int minSujectIndex = Array.IndexOf(ScoreArray, minValue);
            string maxSuject = foundSuject(maxSujectIndex);
            string minSuject = foundSuject(minSujectIndex);
            string showBest = "最高科目成績為 : " + maxSuject + maxValue + "分"
                + "\n最低科目成績為 : " + minSuject + minValue + "分";
            labelShowBest.Text = showBest;
        }

        string foundSuject(int i)
        {
            if (i == 0)
            {
                return "國文";
            }
            else if(i == 1)
            {
                return "英文";
            }
            else
            {
                return "數學";
            }
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            string ShowAll = "姓名 : " + MyName
                + "\n國文 : " + ScoreArray[0]
                + "\n英文 : " + ScoreArray[1]
                + "\n數學 : " + ScoreArray[2];
            labelShowAll.Text = ShowAll;
        }


    }
}
