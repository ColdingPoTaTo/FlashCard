
namespace HW01
{
    partial class Form_HW15_Guess
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
            this.labShowStatus = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnShowAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShowStatus
            // 
            this.labShowStatus.AutoSize = true;
            this.labShowStatus.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowStatus.Location = new System.Drawing.Point(20, 40);
            this.labShowStatus.Name = "labShowStatus";
            this.labShowStatus.Size = new System.Drawing.Size(151, 17);
            this.labShowStatus.TabIndex = 0;
            this.labShowStatus.Text = "Let\'s start Guess game!";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNew.Location = new System.Drawing.Point(20, 150);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 40);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Guess";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnShowAns
            // 
            this.btnShowAns.Enabled = false;
            this.btnShowAns.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAns.Location = new System.Drawing.Point(183, 150);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(130, 40);
            this.btnShowAns.TabIndex = 3;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // Form_HW15_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.labShowStatus);
            this.Name = "Form_HW15_Guess";
            this.Text = "Form_HW15_Guess";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labShowStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnShowAns;
    }
}