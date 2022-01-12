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
    public partial class Form_HW02_Loan : Form
    {
        public Form_HW02_Loan()
        {
            InitializeComponent();
        }

        int PMT = 0;
        int Total = 0;
        double Loan, Year, Rate, First;

        void CountLoan()
        {        
            Loan = Convert.ToDouble(textLoan.Text);
            Year = Convert.ToDouble(textYear.Text);
            Rate = Convert.ToDouble(textRate.Text);
            First = Convert.ToDouble(textFirst.Text);
            double Month = Year * 12;
            double rateRerM = (Rate/100) / 12;
            // 每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            double avgPerMonthRate = (Math.Pow((1 + rateRerM), Month) * rateRerM) / (Math.Pow((1 + rateRerM), Month) - 1);
            if (Rate == 0)
            {
                PMT = Convert.ToInt32((Loan - First) / Month);
            }
            else
            {
                PMT = Convert.ToInt32((Loan - First) * avgPerMonthRate);
            }
            Total = PMT * Convert.ToInt32(Month);                      
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            CountLoan();
            MessageBox.Show("月付額: " + PMT + "元");            
        }

        private void textLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            CountLoan();
            MessageBox.Show("總付款: " + Total + "元");
        }
        
        //產生Report
        private void btnReport_Click(object sender, EventArgs e)
        {
            Form_HW02_LoanReport LReport = new Form_HW02_LoanReport();
            CountLoan();
            LReport.lab_R_Loan.Text = Convert.ToString(Loan);
            LReport.lab_R_Year.Text = Convert.ToString(Year);
            LReport.lab_R_Rate.Text = Convert.ToString(Rate);
            LReport.lab_R_PMT.Text = "" + PMT;
            LReport.lab_R_Total.Text = "" + Total;
            LReport.Show();
        }
    }
}
