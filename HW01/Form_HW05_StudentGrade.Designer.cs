
namespace HW01
{
    partial class Form_HW05_StudentGrade
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
            this.labName = new System.Windows.Forms.Label();
            this.labCH = new System.Windows.Forms.Label();
            this.labEN = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddRan1 = new System.Windows.Forms.Button();
            this.btnSTAT = new System.Windows.Forms.Button();
            this.btnAddRan20 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelAll = new System.Windows.Forms.Panel();
            this.labelTitleHigh = new System.Windows.Forms.Label();
            this.labelTitleLow = new System.Windows.Forms.Label();
            this.labelTitleAVG = new System.Windows.Forms.Label();
            this.labelTitleSum = new System.Windows.Forms.Label();
            this.labelTitleMath = new System.Windows.Forms.Label();
            this.labelTitleEN = new System.Windows.Forms.Label();
            this.labelTitleCH = new System.Windows.Forms.Label();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.panelCaculate = new System.Windows.Forms.Panel();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.panelCaculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(30, 30);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 19);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 :";
            // 
            // labCH
            // 
            this.labCH.AutoSize = true;
            this.labCH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCH.Location = new System.Drawing.Point(30, 70);
            this.labCH.Name = "labCH";
            this.labCH.Size = new System.Drawing.Size(57, 19);
            this.labCH.TabIndex = 1;
            this.labCH.Text = "國文 :";
            // 
            // labEN
            // 
            this.labEN.AutoSize = true;
            this.labEN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEN.Location = new System.Drawing.Point(30, 110);
            this.labEN.Name = "labEN";
            this.labEN.Size = new System.Drawing.Size(57, 19);
            this.labEN.TabIndex = 2;
            this.labEN.Text = "英文 :";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(30, 150);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 19);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學 :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(100, 27);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 30);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCH
            // 
            this.txtCH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH.Location = new System.Drawing.Point(100, 67);
            this.txtCH.MaxLength = 3;
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(90, 30);
            this.txtCH.TabIndex = 5;
            this.txtCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEN.Location = new System.Drawing.Point(100, 107);
            this.txtEN.MaxLength = 3;
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(90, 30);
            this.txtEN.TabIndex = 6;
            this.txtEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(100, 147);
            this.txtMath.MaxLength = 3;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(90, 30);
            this.txtMath.TabIndex = 7;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(48, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 27);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddRan1
            // 
            this.btnAddRan1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRan1.Location = new System.Drawing.Point(48, 223);
            this.btnAddRan1.Name = "btnAddRan1";
            this.btnAddRan1.Size = new System.Drawing.Size(130, 27);
            this.btnAddRan1.TabIndex = 9;
            this.btnAddRan1.Text = "隨機加入資料";
            this.btnAddRan1.UseVisualStyleBackColor = true;
            this.btnAddRan1.Click += new System.EventHandler(this.btnAddRan1_Click);
            // 
            // btnSTAT
            // 
            this.btnSTAT.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSTAT.Location = new System.Drawing.Point(48, 256);
            this.btnSTAT.Name = "btnSTAT";
            this.btnSTAT.Size = new System.Drawing.Size(130, 27);
            this.btnSTAT.TabIndex = 10;
            this.btnSTAT.Text = "各科統計";
            this.btnSTAT.UseVisualStyleBackColor = true;
            this.btnSTAT.Click += new System.EventHandler(this.btnSTAT_Click);
            // 
            // btnAddRan20
            // 
            this.btnAddRan20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRan20.Location = new System.Drawing.Point(48, 355);
            this.btnAddRan20.Name = "btnAddRan20";
            this.btnAddRan20.Size = new System.Drawing.Size(130, 27);
            this.btnAddRan20.TabIndex = 11;
            this.btnAddRan20.Text = "隨機加入20筆";
            this.btnAddRan20.UseVisualStyleBackColor = true;
            this.btnAddRan20.Click += new System.EventHandler(this.btnAddRan20_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(48, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 27);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelAll
            // 
            this.panelAll.AutoScroll = true;
            this.panelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAll.Controls.Add(this.labelTitleHigh);
            this.panelAll.Controls.Add(this.labelTitleLow);
            this.panelAll.Controls.Add(this.labelTitleAVG);
            this.panelAll.Controls.Add(this.labelTitleSum);
            this.panelAll.Controls.Add(this.labelTitleMath);
            this.panelAll.Controls.Add(this.labelTitleEN);
            this.panelAll.Controls.Add(this.labelTitleCH);
            this.panelAll.Controls.Add(this.labelTitleName);
            this.panelAll.Location = new System.Drawing.Point(196, 27);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(526, 256);
            this.panelAll.TabIndex = 13;
            // 
            // labelTitleHigh
            // 
            this.labelTitleHigh.AutoSize = true;
            this.labelTitleHigh.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleHigh.Location = new System.Drawing.Point(458, 16);
            this.labelTitleHigh.Name = "labelTitleHigh";
            this.labelTitleHigh.Size = new System.Drawing.Size(33, 13);
            this.labelTitleHigh.TabIndex = 7;
            this.labelTitleHigh.Text = "最高";
            this.labelTitleHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleLow
            // 
            this.labelTitleLow.AutoSize = true;
            this.labelTitleLow.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleLow.Location = new System.Drawing.Point(388, 16);
            this.labelTitleLow.Name = "labelTitleLow";
            this.labelTitleLow.Size = new System.Drawing.Size(33, 13);
            this.labelTitleLow.TabIndex = 6;
            this.labelTitleLow.Text = "最低";
            this.labelTitleLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleAVG
            // 
            this.labelTitleAVG.AutoSize = true;
            this.labelTitleAVG.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleAVG.Location = new System.Drawing.Point(318, 16);
            this.labelTitleAVG.Name = "labelTitleAVG";
            this.labelTitleAVG.Size = new System.Drawing.Size(33, 13);
            this.labelTitleAVG.TabIndex = 5;
            this.labelTitleAVG.Text = "平均";
            this.labelTitleAVG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleSum
            // 
            this.labelTitleSum.AutoSize = true;
            this.labelTitleSum.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleSum.Location = new System.Drawing.Point(258, 16);
            this.labelTitleSum.Name = "labelTitleSum";
            this.labelTitleSum.Size = new System.Drawing.Size(33, 13);
            this.labelTitleSum.TabIndex = 4;
            this.labelTitleSum.Text = "總分";
            this.labelTitleSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleMath
            // 
            this.labelTitleMath.AutoSize = true;
            this.labelTitleMath.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleMath.Location = new System.Drawing.Point(188, 16);
            this.labelTitleMath.Name = "labelTitleMath";
            this.labelTitleMath.Size = new System.Drawing.Size(33, 13);
            this.labelTitleMath.TabIndex = 3;
            this.labelTitleMath.Text = "數學";
            this.labelTitleMath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleEN
            // 
            this.labelTitleEN.AutoSize = true;
            this.labelTitleEN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleEN.Location = new System.Drawing.Point(128, 16);
            this.labelTitleEN.Name = "labelTitleEN";
            this.labelTitleEN.Size = new System.Drawing.Size(33, 13);
            this.labelTitleEN.TabIndex = 2;
            this.labelTitleEN.Text = "英文";
            this.labelTitleEN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleCH
            // 
            this.labelTitleCH.AutoSize = true;
            this.labelTitleCH.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleCH.Location = new System.Drawing.Point(68, 16);
            this.labelTitleCH.Name = "labelTitleCH";
            this.labelTitleCH.Size = new System.Drawing.Size(33, 13);
            this.labelTitleCH.TabIndex = 1;
            this.labelTitleCH.Text = "國文";
            this.labelTitleCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleName
            // 
            this.labelTitleName.AutoSize = true;
            this.labelTitleName.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitleName.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitleName.Location = new System.Drawing.Point(3, 16);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(33, 13);
            this.labelTitleName.TabIndex = 0;
            this.labelTitleName.Text = "姓名";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCaculate
            // 
            this.panelCaculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCaculate.Controls.Add(this.lab4);
            this.panelCaculate.Controls.Add(this.lab1);
            this.panelCaculate.Controls.Add(this.lab3);
            this.panelCaculate.Controls.Add(this.lab2);
            this.panelCaculate.Location = new System.Drawing.Point(196, 289);
            this.panelCaculate.Name = "panelCaculate";
            this.panelCaculate.Size = new System.Drawing.Size(526, 110);
            this.panelCaculate.TabIndex = 14;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab4.Location = new System.Drawing.Point(188, 11);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(0, 13);
            this.lab4.TabIndex = 11;
            this.lab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.SystemColors.Control;
            this.lab1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(3, 11);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 13);
            this.lab1.TabIndex = 8;
            this.lab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab3.Location = new System.Drawing.Point(128, 11);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(0, 13);
            this.lab3.TabIndex = 10;
            this.lab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(68, 11);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(0, 13);
            this.lab2.TabIndex = 9;
            this.lab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_HW05_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panelCaculate);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddRan20);
            this.Controls.Add(this.btnSTAT);
            this.Controls.Add(this.btnAddRan1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEN);
            this.Controls.Add(this.labCH);
            this.Controls.Add(this.labName);
            this.Name = "Form_HW05_StudentGrade";
            this.Text = "Form_HW05_StudentGrade";
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.panelCaculate.ResumeLayout(false);
            this.panelCaculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCH;
        private System.Windows.Forms.Label labEN;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddRan1;
        private System.Windows.Forms.Button btnSTAT;
        private System.Windows.Forms.Button btnAddRan20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Label labelTitleHigh;
        private System.Windows.Forms.Label labelTitleLow;
        private System.Windows.Forms.Label labelTitleAVG;
        private System.Windows.Forms.Label labelTitleSum;
        private System.Windows.Forms.Label labelTitleMath;
        private System.Windows.Forms.Label labelTitleEN;
        private System.Windows.Forms.Label labelTitleCH;
        private System.Windows.Forms.Label labelTitleName;
        private System.Windows.Forms.Panel panelCaculate;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
    }
}