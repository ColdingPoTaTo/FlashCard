
namespace HW01
{
    partial class Form_HW02_LoanReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRLoan = new System.Windows.Forms.Label();
            this.labelRYear = new System.Windows.Forms.Label();
            this.labelRRate = new System.Windows.Forms.Label();
            this.labelRMonth = new System.Windows.Forms.Label();
            this.labelRTotal = new System.Windows.Forms.Label();
            this.lab_R_Loan = new System.Windows.Forms.Label();
            this.lab_R_Year = new System.Windows.Forms.Label();
            this.lab_R_Rate = new System.Windows.Forms.Label();
            this.lab_R_PMT = new System.Windows.Forms.Label();
            this.lab_R_Total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRLoan
            // 
            this.labelRLoan.AutoSize = true;
            this.labelRLoan.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRLoan.Location = new System.Drawing.Point(60, 30);
            this.labelRLoan.Name = "labelRLoan";
            this.labelRLoan.Size = new System.Drawing.Size(118, 24);
            this.labelRLoan.TabIndex = 0;
            this.labelRLoan.Text = "貸款金額 :";
            // 
            // labelRYear
            // 
            this.labelRYear.AutoSize = true;
            this.labelRYear.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRYear.Location = new System.Drawing.Point(60, 80);
            this.labelRYear.Name = "labelRYear";
            this.labelRYear.Size = new System.Drawing.Size(110, 24);
            this.labelRYear.TabIndex = 1;
            this.labelRYear.Text = "期限(年) :";
            // 
            // labelRRate
            // 
            this.labelRRate.AutoSize = true;
            this.labelRRate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRRate.Location = new System.Drawing.Point(60, 130);
            this.labelRRate.Name = "labelRRate";
            this.labelRRate.Size = new System.Drawing.Size(105, 24);
            this.labelRRate.TabIndex = 2;
            this.labelRRate.Text = "利率(%) :";
            // 
            // labelRMonth
            // 
            this.labelRMonth.AutoSize = true;
            this.labelRMonth.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRMonth.Location = new System.Drawing.Point(60, 180);
            this.labelRMonth.Name = "labelRMonth";
            this.labelRMonth.Size = new System.Drawing.Size(94, 24);
            this.labelRMonth.TabIndex = 3;
            this.labelRMonth.Text = "月付款 :";
            // 
            // labelRTotal
            // 
            this.labelRTotal.AutoSize = true;
            this.labelRTotal.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRTotal.Location = new System.Drawing.Point(60, 230);
            this.labelRTotal.Name = "labelRTotal";
            this.labelRTotal.Size = new System.Drawing.Size(94, 24);
            this.labelRTotal.TabIndex = 4;
            this.labelRTotal.Text = "總付款 :";
            // 
            // lab_R_Loan
            // 
            this.lab_R_Loan.AutoEllipsis = true;
            this.lab_R_Loan.AutoSize = true;
            this.lab_R_Loan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_R_Loan.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_R_Loan.Location = new System.Drawing.Point(190, 30);
            this.lab_R_Loan.Name = "lab_R_Loan";
            this.lab_R_Loan.Size = new System.Drawing.Size(23, 23);
            this.lab_R_Loan.TabIndex = 5;
            this.lab_R_Loan.Text = "0";
            this.lab_R_Loan.Click += new System.EventHandler(this.lab_R_Loan_Click);
            // 
            // lab_R_Year
            // 
            this.lab_R_Year.AutoSize = true;
            this.lab_R_Year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_R_Year.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_R_Year.Location = new System.Drawing.Point(190, 80);
            this.lab_R_Year.Name = "lab_R_Year";
            this.lab_R_Year.Size = new System.Drawing.Size(23, 23);
            this.lab_R_Year.TabIndex = 6;
            this.lab_R_Year.Text = "0";
            // 
            // lab_R_Rate
            // 
            this.lab_R_Rate.AutoSize = true;
            this.lab_R_Rate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_R_Rate.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_R_Rate.Location = new System.Drawing.Point(190, 130);
            this.lab_R_Rate.Name = "lab_R_Rate";
            this.lab_R_Rate.Size = new System.Drawing.Size(23, 23);
            this.lab_R_Rate.TabIndex = 7;
            this.lab_R_Rate.Text = "0";
            // 
            // lab_R_PMT
            // 
            this.lab_R_PMT.AutoSize = true;
            this.lab_R_PMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_R_PMT.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_R_PMT.Location = new System.Drawing.Point(190, 180);
            this.lab_R_PMT.Name = "lab_R_PMT";
            this.lab_R_PMT.Size = new System.Drawing.Size(23, 23);
            this.lab_R_PMT.TabIndex = 8;
            this.lab_R_PMT.Text = "0";
            // 
            // lab_R_Total
            // 
            this.lab_R_Total.AutoSize = true;
            this.lab_R_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_R_Total.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_R_Total.Location = new System.Drawing.Point(190, 230);
            this.lab_R_Total.Name = "lab_R_Total";
            this.lab_R_Total.Size = new System.Drawing.Size(23, 23);
            this.lab_R_Total.TabIndex = 9;
            this.lab_R_Total.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(257, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_HW02_LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_R_Total);
            this.Controls.Add(this.lab_R_PMT);
            this.Controls.Add(this.lab_R_Rate);
            this.Controls.Add(this.lab_R_Year);
            this.Controls.Add(this.lab_R_Loan);
            this.Controls.Add(this.labelRTotal);
            this.Controls.Add(this.labelRMonth);
            this.Controls.Add(this.labelRRate);
            this.Controls.Add(this.labelRYear);
            this.Controls.Add(this.labelRLoan);
            this.Name = "Form_HW02_LoanReport";
            this.Text = "MyHomeWork_02_LoanReport";
            this.Load += new System.EventHandler(this.Form_HW02_LoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRLoan;
        private System.Windows.Forms.Label labelRYear;
        private System.Windows.Forms.Label labelRRate;
        private System.Windows.Forms.Label labelRMonth;
        private System.Windows.Forms.Label labelRTotal;
        public System.Windows.Forms.Label lab_R_Loan;
        public System.Windows.Forms.Label lab_R_Year;
        public System.Windows.Forms.Label lab_R_Rate;
        public System.Windows.Forms.Label lab_R_PMT;
        public System.Windows.Forms.Label lab_R_Total;
        private System.Windows.Forms.Button button1;
    }
}