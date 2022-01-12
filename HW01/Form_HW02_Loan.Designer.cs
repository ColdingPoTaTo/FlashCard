
namespace HW01
{
    partial class Form_HW02_Loan
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
            this.labelLoan = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.textLoan = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textRate = new System.Windows.Forms.TextBox();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoan
            // 
            this.labelLoan.AutoSize = true;
            this.labelLoan.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLoan.Location = new System.Drawing.Point(40, 40);
            this.labelLoan.Name = "labelLoan";
            this.labelLoan.Size = new System.Drawing.Size(106, 24);
            this.labelLoan.TabIndex = 0;
            this.labelLoan.Text = "貸款金額";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelYear.Location = new System.Drawing.Point(40, 90);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(98, 24);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "期限(年)";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRate.Location = new System.Drawing.Point(40, 140);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(93, 24);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "利率(%)";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFirst.Location = new System.Drawing.Point(40, 190);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(82, 24);
            this.labelFirst.TabIndex = 3;
            this.labelFirst.Text = "頭期款";
            // 
            // textLoan
            // 
            this.textLoan.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLoan.Location = new System.Drawing.Point(180, 40);
            this.textLoan.Name = "textLoan";
            this.textLoan.Size = new System.Drawing.Size(154, 30);
            this.textLoan.TabIndex = 4;
            this.textLoan.Text = "100000";
            this.textLoan.TextChanged += new System.EventHandler(this.textLoan_TextChanged);
            // 
            // textYear
            // 
            this.textYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textYear.Location = new System.Drawing.Point(180, 90);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(154, 30);
            this.textYear.TabIndex = 5;
            this.textYear.Text = "2";
            // 
            // textRate
            // 
            this.textRate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textRate.Location = new System.Drawing.Point(180, 140);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(154, 30);
            this.textRate.TabIndex = 6;
            this.textRate.Text = "10";
            // 
            // textFirst
            // 
            this.textFirst.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFirst.Location = new System.Drawing.Point(180, 190);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(154, 30);
            this.textFirst.TabIndex = 7;
            this.textFirst.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(40, 250);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(120, 44);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(180, 250);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(120, 44);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(320, 250);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 44);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form_HW02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textLoan);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelLoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_HW02_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoan;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.TextBox textLoan;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}