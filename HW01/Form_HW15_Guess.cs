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
    public partial class Form_HW15_Guess : Form
    {
        public Form_HW15_Guess()
        {
            InitializeComponent();            
        }
        internal Form_HW15_Guess_userWindow GuessWindow = new Form_HW15_Guess_userWindow();
        Random RND = new Random();
        internal static int theTopic, theMin, theMax;        
        internal string showInfo;

        //比大小，如果答對，回傳true
        internal Boolean checkTheAnswer(int userAnswer)
        {
            if (userAnswer == theTopic)
            {
                return true;
            }
            else if (userAnswer > theTopic)
            {
                theMax = userAnswer;
                showInfo = "Too Large!!!" + "\nBetween " + theMin + " and " + theMax;
                labShowStatus.Text = showInfo;
                return false;
            }
            else
            {
                theMin = userAnswer;
                showInfo = "Too Small!!!" + "\nBetween " + theMin + " and " + theMax;
                labShowStatus.Text = showInfo;
                return false;
            }
        }
               
        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : " + theTopic);            
        }

        internal void btnNew_Click(object sender, EventArgs e)
        {
            theTopic = RND.Next(1, 100);
            theMin = 1;
            theMax = 100;
            btnShowAns.Enabled = true;
            labShowStatus.Text = "Please Select A Number Between 1 to 100!";
            GuessWindow.mainForm = this; //將this指派到formB裡面去使用
            GuessWindow.ShowDialog(); //顯示新form，強制user回應
        }
    }
}
