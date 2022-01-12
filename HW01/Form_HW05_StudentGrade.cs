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
    public partial class Form_HW05_StudentGrade : Form
    {
        public Form_HW05_StudentGrade()
        {
            InitializeComponent();
        }

        studentGrade SG;
        studentGrade[] sgArr = new studentGrade[100];
        Random RND = new Random();
        public int round = 0;

        void showAll()
        {
            labelTitleName.Text = "姓名\n\n";
            labelTitleCH.Text= "國文\n\n";
            labelTitleEN.Text = "英文\n\n";
            labelTitleMath.Text = "數學\n\n";
            labelTitleSum.Text = "總分\n\n";
            labelTitleAVG.Text = "平均\n\n";
            labelTitleLow.Text = "最低\n\n";
            labelTitleHigh.Text = "最高\n\n";
            for (int i = 0; i < round; i++)
            {
                labelTitleName.Text += sgArr[i].Name + "\n";
                labelTitleCH.Text += sgArr[i].scoreCH + "\n";
                labelTitleEN.Text += sgArr[i].scoreEN + "\n";
                labelTitleMath.Text += sgArr[i].scoreMath + "\n";
                labelTitleSum.Text += sgArr[i].scoreSum + "\n";
                labelTitleAVG.Text += sgArr[i].scoreAVG + "\n";
                labelTitleLow.Text += sgArr[i].scoreLow + "\n";
                labelTitleHigh.Text += sgArr[i].scoreHigh + "\n";
            }
        }

        void checkSubject(string studentName, string scoreCH, string scoreEN, string scoreMath)
        {            
            double CH = Convert.ToDouble(scoreCH);
            double EN = Convert.ToDouble(scoreEN);
            double Math = Convert.ToDouble(scoreMath);
            double Sum = CH + EN + Math;
            double AVG = Sum / 3;

            double[] scoreArray = { CH, EN, Math };
            // Finding max
            double getMax = scoreArray.Max();
            double getMin = scoreArray.Min();
            // Positioning max
            int positionMax = Array.IndexOf(scoreArray, getMax);
            int positionMin = Array.IndexOf(scoreArray, getMin);
            string highScore = checkSubjectName(positionMax)+ getMax;
            string lowScore = checkSubjectName(positionMin)+ getMin;

            SG.Name = studentName;
            SG.scoreCH = Convert.ToInt32(CH);
            SG.scoreEN = Convert.ToInt32(EN);
            SG.scoreMath = Convert.ToInt32(Math);
            SG.scoreSum = Convert.ToString(Sum);
            SG.scoreAVG = AVG.ToString("0.0");
            SG.scoreLow = lowScore;
            SG.scoreHigh = highScore;
            
            sgArr[round] = SG;
            round++;            

            string checkSubjectName(int index)
            {
                string subject = "";
                switch (index)
                {
                    case 0:
                        subject = "國文";
                        break;
                    case 1:
                        subject = "英文";
                        break;
                    case 2:
                        subject = "數學";
                        break;
                }
                return subject;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    throw new Exception();
                }                
                Convert.ToDouble(txtCH.Text);
                Convert.ToDouble(txtEN.Text);
                Convert.ToDouble(txtMath.Text);
                checkSubject(txtName.Text, txtCH.Text, txtEN.Text, txtMath.Text);
                showAll();
            }
            catch
            {
                MessageBox.Show("請依下列格式輸入:\n\n姓名: 10個字元\n國文: 0~100數字\n英文: 0~100數字\n數學: 0~100數字", "輸入錯誤!!");
            }
            
        }

        private void btnAddRan1_Click(object sender, EventArgs e)
        {            
            string Name = (round+1).ToString();
            string CH = RND.Next(0, 100).ToString();
            string EN= RND.Next(0, 100).ToString();
            string Math= RND.Next(0, 100).ToString();
            checkSubject(Name, CH, EN, Math);
            showAll();
        }

        private void btnAddRan20_Click(object sender, EventArgs e)
        {
            for(int i =1; i < 21; i++)
            {
                string Name = (round + 1).ToString();
                string CH = RND.Next(0, 100).ToString();
                string EN = RND.Next(0, 100).ToString();
                string Math = RND.Next(0, 100).ToString();
                checkSubject(Name, CH, EN, Math);                
            }
            showAll();
        }
              
        private void btnSTAT_Click(object sender, EventArgs e)
        {

            double sumCH = 0.0, sumEN = 0.0, sumMath = 0.0, avgCH, avgEN, avgMath;
            int theMaxCH=0, theMinCH=100, theMaxEN = 0, theMinEN = 100, theMaxMath = 0, theMinMath = 100;
            for (int i = 0; i < round; i++)
            {
                sumCH += sgArr[i].scoreCH;
                sumEN += sgArr[i].scoreEN;
                sumMath += sgArr[i].scoreMath;
                theMaxCH = theMaxCH > sgArr[i].scoreCH ? theMaxCH : sgArr[i].scoreCH;
                theMinCH = theMinCH < sgArr[i].scoreCH ? theMinCH : sgArr[i].scoreCH;
                theMaxEN = theMaxEN > sgArr[i].scoreEN ? theMaxEN : sgArr[i].scoreEN;
                theMinEN = theMinEN < sgArr[i].scoreEN ? theMinEN : sgArr[i].scoreEN;
                theMaxMath = theMaxMath > sgArr[i].scoreMath ? theMaxMath : sgArr[i].scoreMath;
                theMinMath = theMinMath < sgArr[i].scoreMath ? theMinMath : sgArr[i].scoreMath;
            }
            avgCH = sumCH / round;
            avgEN = sumEN / round;
            avgMath = sumMath / round;
            lab1.Text = "總分\n平均\n最高分\n最低分";
            lab2.Text = sumCH + "\n" + avgCH.ToString("0.0") + "\n" + theMaxCH + "\n" + theMinCH;
            lab3.Text = sumEN + "\n" + avgEN.ToString("0.0") + "\n" + theMaxEN + "\n" + theMinEN;
            lab4.Text = sumMath + "\n" + avgMath.ToString("0.0") + "\n" + theMaxMath + "\n" + theMinMath;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Array.Clear(sgArr, 0, 100);
            round = 0;
            showAll();
            lab1.Text = "";
            lab2.Text = "";
            lab3.Text = "";
            lab4.Text = "";
        }
    }

    public struct studentGrade
    {        
        public string Name, scoreSum, scoreAVG, scoreLow, scoreHigh;
        public int scoreCH, scoreEN, scoreMath;
    }
}
