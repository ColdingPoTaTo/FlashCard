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
    public partial class Form_HW15_Guess_userWindow : Form
    {
        public Form_HW15_Guess_userWindow()
        {
            InitializeComponent();            
        }
        internal Form_HW15_Guess mainForm;

        //判斷有沒有非法字元
        int checkLegal()
        {
            int userInput;
            try
            {
                userInput = Convert.ToInt32(txtUserInput.Text);
                if (userInput < Form_HW15_Guess.theMin || userInput > Form_HW15_Guess.theMax)
                {
                    throw new Exception();
                }
                return userInput;
            }
            catch
            {
                MessageBox.Show("請輸入" + Form_HW15_Guess.theMin + "~" + Form_HW15_Guess.theMax + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userInput = -1; //-1表示玩家輸入不合法
                return userInput;
            }
        }

        internal void btn2Enter_Click(object sender, EventArgs e)
        {
            int userInput = checkLegal(); //確認是否合法
            switch (userInput)
            {
                case -1: //輸入不合法，結束動作
                    break;
                default:
                    Boolean isWin = mainForm.checkTheAnswer(userInput); //合法就去比大小
                    if (isWin)
                    {
                        mainForm.labShowStatus.Text = "Congratulations!!! \nYou got the answer " + Form_HW15_Guess.theTopic + "!!!";
                        MessageBox.Show("Congratulations!!! You got the answer" + Form_HW15_Guess.theTopic + "!!!");
                        this.Close();
                    }
                    break;
            }
        }

        internal void btn2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 按下enter後不要出現提示音                
                btn2Enter_Click(sender, e);
                txtUserInput.Focus();
                txtUserInput.Clear();
            }
        }
    }
}
