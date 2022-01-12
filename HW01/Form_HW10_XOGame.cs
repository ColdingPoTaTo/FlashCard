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
    public partial class Form_HW10_XOGame : Form
    {
        public Form_HW10_XOGame()
        {
            InitializeComponent();
        }
        //當前回合，預設X
        string Round = "X";
        //CalRound:1代表X，-1代表O ; step表示目前步數，9步會結束遊戲
        int CalRound = 1, step = 0;
        string winner="";
        //winnerSet存放所有獲勝方式
        int[,] winnerSet = new int[8, 3] {
            { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, 
            { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, 
            { 1, 5, 9 }, { 3, 5, 7 },         };
        //gameDic存放玩家移動資料
        Dictionary<int, int> gameDic = new Dictionary<int, int>()
        {
            {1 , 0}, {2 , 0}, {3 , 0},
            {4 , 0}, {5 , 0}, {6 , 0},
            {7 , 0}, {8 , 0}, {9 , 0},
        };

        //交換回合
        void roundSwitch(ref string Round)
        {
            if (Round == "X")
            {
                Round = "O";
                CalRound = -1;
            }
            else
            {
                Round = "X";
                CalRound = 1;
            }
            this.Focus();
        }
        
        //判斷是否有獲勝情形
        void checkWinner()
        {
            step++;
            for (int i=0; i<8; i++)
            {
                int sumW = 0;
                for(int j=0; j<3; j++)
                {
                    int k = winnerSet[i, j];
                    sumW += gameDic[k];                    
                }
                //MessageBox.Show("" + sumW);
                switch (sumW)
                {
                    case 3:
                        winner = "X";
                        break;
                    case -3:
                        winner = "O";
                        break;
                }
            }
            switch (winner)
            {
                case "X":
                    MessageBox.Show("X 玩家獲勝", "完局!");
                    closeBTN();
                    break;
                case "O":
                    MessageBox.Show("O 玩家獲勝", "完局!");
                    closeBTN();
                    break;
                default:
                    if (step == 9)
                    {
                        MessageBox.Show("平手! 按下確定重新開始","完局!");
                        restartGame();
                    }
                    break;                    
            }            
        }

        //重啟遊戲
        void restartGame()
        {
            for (int i = 1; i < 10; i++)
            {
                gameDic[i] = 0;
            }
            openBTN();
            Round = "X";
            CalRound = 1;
            winner = "";
            step = 0;
        }

        //關閉所有按紐
        void closeBTN()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        //開啟所有按紐
        void openBTN()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";            
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = Round; //顯示XO
            btn1.Enabled = false;
            gameDic[1] = CalRound; //儲存資料到gameTable
            checkWinner();            
            roundSwitch(ref Round); //回合交換
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = Round; //顯示XO
            btn2.Enabled = false;
            gameDic[2] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = Round; //顯示XO
            btn3.Enabled = false;
            gameDic[3] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = Round; //顯示XO
            btn4.Enabled = false;
            gameDic[4] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = Round; //顯示XO
            btn5.Enabled = false;
            gameDic[5] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = Round; //顯示XO
            btn6.Enabled = false;
            gameDic[6] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = Round; //顯示XO
            btn7.Enabled = false;
            gameDic[7] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = Round; //顯示XO
            btn8.Enabled = false;
            gameDic[8] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = Round; //顯示XO
            btn9.Enabled = false;
            gameDic[9] = CalRound; //儲存資料到gameTable
            checkWinner();
            roundSwitch(ref Round); //回合交換
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        //keyDown
        private void Form_HW10_XOGame_KeyDown(object sender, KeyEventArgs e)
        {    
            switch (e.KeyCode)
            {
                case Keys.R:
                    restartGame();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.NumPad7:
                    btn1_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    btn2_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    btn3_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    btn4_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    btn5_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    btn6_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    btn7_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    btn8_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    btn9_Click(sender, e);
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
