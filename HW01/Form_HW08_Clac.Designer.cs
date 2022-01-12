
namespace HW01
{
    partial class Form_HW08_Clac
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
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelAns = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labelTheAns = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum1.Location = new System.Drawing.Point(50, 50);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(64, 19);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "Num1:";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum2.Location = new System.Drawing.Point(50, 100);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(64, 19);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "Num2:";
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAns.Location = new System.Drawing.Point(37, 160);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(77, 19);
            this.labelAns.TabIndex = 2;
            this.labelAns.Text = "Answer:";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLine.Location = new System.Drawing.Point(38, 130);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(192, 16);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "=======================";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(120, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(90, 27);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(120, 100);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(90, 27);
            this.txtNum2.TabIndex = 5;
            // 
            // labelTheAns
            // 
            this.labelTheAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTheAns.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTheAns.Location = new System.Drawing.Point(120, 160);
            this.labelTheAns.Name = "labelTheAns";
            this.labelTheAns.Size = new System.Drawing.Size(90, 27);
            this.labelTheAns.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(230, 40);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(230, 92);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 35);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMulti.Location = new System.Drawing.Point(280, 40);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(35, 35);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivid
            // 
            this.btnDivid.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivid.Location = new System.Drawing.Point(280, 92);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(35, 35);
            this.btnDivid.TabIndex = 10;
            this.btnDivid.Text = "/";
            this.btnDivid.UseVisualStyleBackColor = true;
            this.btnDivid.Click += new System.EventHandler(this.btnDivid_Click);
            // 
            // Form_HW08_Clac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.btnDivid);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.labelTheAns);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Name = "Form_HW08_Clac";
            this.Text = "MyHomeWork_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labelTheAns;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivid;
    }
}