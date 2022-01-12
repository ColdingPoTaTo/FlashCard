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
    public partial class Form_HW06_StudentList : Form
    {
        public Form_HW06_StudentList()
        {
            InitializeComponent();
        }
        //變數宣告
        StudentList SL;        
        List<StudentList> SList = new List<StudentList>();
        List<StudentList> SearchList = new List<StudentList>();
        Random RND = new Random();
        public int round = 0;

        void showAll()
        {
            labelTitleName.Text = "姓名\n\n";
            labelTitleCH.Text = "國文\n\n";
            labelTitleEN.Text = "英文\n\n";
            labelTitleMath.Text = "數學\n\n";
            labelTitleSum.Text = "總分\n\n";
            labelTitleAVG.Text = "平均\n\n";
            labelTitleLow.Text = "最低\n\n";
            labelTitleHigh.Text = "最高\n\n";
            
            foreach (StudentList i in SList)
            {
                labelTitleName.Text += i.Name + "\n";
                labelTitleCH.Text += i.scoreCH + "\n";
                labelTitleEN.Text += i.scoreEN + "\n";
                labelTitleMath.Text += i.scoreMath + "\n";
                labelTitleSum.Text += i.scoreSum + "\n";
                labelTitleAVG.Text += i.scoreAVG + "\n";
                labelTitleLow.Text += i.scoreLow + "\n";
                labelTitleHigh.Text += i.scoreHigh + "\n";
            }
        }

        void checkSubject(string studentName, string scoreCH, string scoreEN, string scoreMath, Boolean isInsert = false)
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
            string highScore = checkSubjectName(positionMax) + getMax;
            string lowScore = checkSubjectName(positionMin) + getMin;

            //MessageBox.Show("check check", "check point3");
            SL.Name = studentName;
            SL.scoreCH = Convert.ToInt32(CH);
            SL.scoreEN = Convert.ToInt32(EN);
            SL.scoreMath = Convert.ToInt32(Math);
            SL.scoreSum = Convert.ToString(Sum);
            SL.scoreAVG = AVG.ToString("0.0");
            SL.scoreLow = lowScore;
            SL.scoreHigh = highScore;
            
            if (isInsert)
                SList.Insert(0, SL);
            else
                SList.Add(SL);
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

        private void btnInsert_Click(object sender, EventArgs e)
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

                checkSubject(txtName.Text, txtCH.Text, txtEN.Text, txtMath.Text,true);                
                showAll();
            }
            catch
            {
                MessageBox.Show("請依下列格式輸入:\n\n姓名: 10個字元\n國文: 0~100數字\n英文: 0~100數字\n數學: 0~100數字", "輸入錯誤!!");
            }
        }

        private void btnAddRan1_Click(object sender, EventArgs e)
        {
            string Name = (round + 1).ToString();
            string CH = RND.Next(0, 100).ToString();
            string EN = RND.Next(0, 100).ToString();
            string Math = RND.Next(0, 100).ToString();
            checkSubject(Name, CH, EN, Math);
            showAll();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            SList.RemoveAt(0);
            round--;
            showAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SList.Clear();
            round = 0;
            showAll();
        }

        private void btnSTAT_Click(object sender, EventArgs e)
        {
            double sumCH = 0.0, sumEN = 0.0, sumMath = 0.0, avgCH, avgEN, avgMath;
            int theMaxCH = 0, theMinCH = 100, theMaxEN = 0, theMinEN = 100, theMaxMath = 0, theMinMath = 100;
            foreach(StudentList i in SList)
            {
                sumCH += i.scoreCH;
                sumEN += i.scoreEN;
                sumMath += i.scoreMath;
                theMaxCH = theMaxCH > i.scoreCH ? theMaxCH : i.scoreCH;
                theMinCH = theMinCH < i.scoreCH ? theMinCH : i.scoreCH;
                theMaxEN = theMaxEN > i.scoreEN ? theMaxEN : i.scoreEN;
                theMinEN = theMinEN < i.scoreEN ? theMinEN : i.scoreEN;
                theMaxMath = theMaxMath > i.scoreMath ? theMaxMath : i.scoreMath;
                theMinMath = theMinMath < i.scoreMath ? theMinMath : i.scoreMath;
            }
            avgCH = sumCH / round;
            avgEN = sumEN / round;
            avgMath = sumMath / round;
            lab1.Text = "總分\n平均\n最高分\n最低分";
            lab2.Text = sumCH + "\n" + avgCH.ToString("0.0") + "\n" + theMaxCH + "\n" + theMinCH;
            lab3.Text = sumEN + "\n" + avgEN.ToString("0.0") + "\n" + theMaxEN + "\n" + theMinEN;
            lab4.Text = sumMath + "\n" + avgMath.ToString("0.0") + "\n" + theMaxMath + "\n" + theMinMath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int rangeMin=0, rangeMax=100;
            
            try
            {
                rangeMin = Convert.ToInt32(txtRangeMin.Text);
                rangeMax = Convert.ToInt32(txtRangeMax.Text);
                if (rangeMin>=rangeMax)
                {
                    //throw new Exception();
                    throw new ArgumentException("左邊是範圍最小值，右邊是範圍最大值\n最小值必須小於最大值");
                }      
                checkSubject(txtName.Text, txtCH.Text, txtEN.Text, txtMath.Text);
                showAll();
            }
            catch
            {
                MessageBox.Show("請依下列格式輸入:\n\n姓名: 10個字元\n國文: 0~100數字\n英文: 0~100數字\n數學: 0~100數字", "輸入錯誤!!");
            }

            labelTitleName.Text = "姓名\n\n";
            labelTitleCH.Text = "國文\n\n";
            labelTitleEN.Text = "英文\n\n";
            labelTitleMath.Text = "數學\n\n";
            labelTitleSum.Text = "總分\n\n";
            labelTitleAVG.Text = "平均\n\n";
            labelTitleLow.Text = "最低\n\n";
            labelTitleHigh.Text = "最高\n\n";

            foreach (StudentList i in SList)
            {              
                if (i.scoreCH>=rangeMin && i.scoreCH <= rangeMax)
                {
                    labelTitleName.Text += i.Name + "\n";
                    labelTitleCH.Text += i.scoreCH + "\n";
                    labelTitleEN.Text += i.scoreEN + "\n";
                    labelTitleMath.Text += i.scoreMath + "\n";
                    labelTitleSum.Text += i.scoreSum + "\n";
                    labelTitleAVG.Text += i.scoreAVG + "\n";
                    labelTitleLow.Text += i.scoreLow + "\n";
                    labelTitleHigh.Text += i.scoreHigh + "\n";
                }
                else
                {
                    continue;
                }
            }
        }
    }






    public struct StudentList
    {
        //string Name, scoreCH, scoreEN, scoreMath, scoreSum, scoreAVG, scoreLow, scoreHigh;
        public string Name, scoreSum, scoreAVG, scoreLow, scoreHigh;
        public int scoreCH, scoreEN, scoreMath;
    }


}
