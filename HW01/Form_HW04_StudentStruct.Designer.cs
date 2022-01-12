
namespace HW01
{
    partial class Form_HW04_StudentStruct
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
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelShowBest = new System.Windows.Forms.Label();
            this.labelShowAll = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.labelEN = new System.Windows.Forms.Label();
            this.labelMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.btnSaveArray = new System.Windows.Forms.Button();
            this.btnShowBest = new System.Windows.Forms.Button();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelShowBest);
            this.groupBoxScore.Controls.Add(this.labelShowAll);
            this.groupBoxScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxScore.Location = new System.Drawing.Point(270, 20);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(280, 280);
            this.groupBoxScore.TabIndex = 0;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "成績";
            // 
            // labelShowBest
            // 
            this.labelShowBest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowBest.Location = new System.Drawing.Point(6, 169);
            this.labelShowBest.Name = "labelShowBest";
            this.labelShowBest.Size = new System.Drawing.Size(268, 108);
            this.labelShowBest.TabIndex = 1;
            // 
            // labelShowAll
            // 
            this.labelShowAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowAll.Location = new System.Drawing.Point(6, 26);
            this.labelShowAll.Name = "labelShowAll";
            this.labelShowAll.Size = new System.Drawing.Size(268, 135);
            this.labelShowAll.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.Location = new System.Drawing.Point(40, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "姓名:";
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCH.Location = new System.Drawing.Point(40, 110);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(52, 19);
            this.labelCH.TabIndex = 2;
            this.labelCH.Text = "國文:";
            // 
            // labelEN
            // 
            this.labelEN.AutoSize = true;
            this.labelEN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEN.Location = new System.Drawing.Point(40, 160);
            this.labelEN.Name = "labelEN";
            this.labelEN.Size = new System.Drawing.Size(52, 19);
            this.labelEN.TabIndex = 3;
            this.labelEN.Text = "英文:";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMath.Location = new System.Drawing.Point(40, 210);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(52, 19);
            this.labelMath.TabIndex = 4;
            this.labelMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(100, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 30);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCH
            // 
            this.txtCH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH.Location = new System.Drawing.Point(100, 105);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(118, 30);
            this.txtCH.TabIndex = 6;
            this.txtCH.Text = "0";
            this.txtCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEN.Location = new System.Drawing.Point(100, 155);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(118, 30);
            this.txtEN.TabIndex = 7;
            this.txtEN.Text = "0";
            this.txtEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(100, 205);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(118, 30);
            this.txtMath.TabIndex = 8;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowArray
            // 
            this.btnShowArray.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowArray.Location = new System.Drawing.Point(159, 261);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(105, 35);
            this.btnShowArray.TabIndex = 9;
            this.btnShowArray.Text = "顯示儲存內容";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // btnSaveArray
            // 
            this.btnSaveArray.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveArray.Location = new System.Drawing.Point(44, 262);
            this.btnSaveArray.Name = "btnSaveArray";
            this.btnSaveArray.Size = new System.Drawing.Size(105, 35);
            this.btnSaveArray.TabIndex = 10;
            this.btnSaveArray.Text = "儲存";
            this.btnSaveArray.UseVisualStyleBackColor = true;
            this.btnSaveArray.Click += new System.EventHandler(this.btnSaveArray_Click);
            // 
            // btnShowBest
            // 
            this.btnShowBest.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowBest.Location = new System.Drawing.Point(401, 306);
            this.btnShowBest.Name = "btnShowBest";
            this.btnShowBest.Size = new System.Drawing.Size(140, 40);
            this.btnShowBest.TabIndex = 11;
            this.btnShowBest.Text = "最高分/最低分科目";
            this.btnShowBest.UseVisualStyleBackColor = true;
            this.btnShowBest.Click += new System.EventHandler(this.btnShowBest_Click);
            // 
            // Form_HW04_StudentStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnShowBest);
            this.Controls.Add(this.btnSaveArray);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEN);
            this.Controls.Add(this.labelCH);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxScore);
            this.Name = "Form_HW04_StudentStruct";
            this.Text = "Student_StructForm";
            this.groupBoxScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShowBest;
        private System.Windows.Forms.Label labelShowAll;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Label labelEN;
        private System.Windows.Forms.Label labelMath;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtCH;
        internal System.Windows.Forms.TextBox txtEN;
        internal System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnShowArray;
        private System.Windows.Forms.Button btnSaveArray;
        private System.Windows.Forms.Button btnShowBest;
    }
}