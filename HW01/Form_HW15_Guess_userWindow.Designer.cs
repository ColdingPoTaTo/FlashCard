
namespace HW01
{
    partial class Form_HW15_Guess_userWindow
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
            this.labNotice = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btn2Enter = new System.Windows.Forms.Button();
            this.btn2Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNotice
            // 
            this.labNotice.AutoSize = true;
            this.labNotice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNotice.Location = new System.Drawing.Point(12, 36);
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(182, 20);
            this.labNotice.TabIndex = 0;
            this.labNotice.Text = "Please input a number.";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserInput.Location = new System.Drawing.Point(16, 95);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(178, 29);
            this.txtUserInput.TabIndex = 1;
            this.txtUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserInput_KeyDown);
            // 
            // btn2Enter
            // 
            this.btn2Enter.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2Enter.Location = new System.Drawing.Point(208, 33);
            this.btn2Enter.Name = "btn2Enter";
            this.btn2Enter.Size = new System.Drawing.Size(64, 31);
            this.btn2Enter.TabIndex = 2;
            this.btn2Enter.Text = "Enter";
            this.btn2Enter.UseVisualStyleBackColor = true;
            this.btn2Enter.Click += new System.EventHandler(this.btn2Enter_Click);
            // 
            // btn2Cancel
            // 
            this.btn2Cancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2Cancel.Location = new System.Drawing.Point(208, 93);
            this.btn2Cancel.Name = "btn2Cancel";
            this.btn2Cancel.Size = new System.Drawing.Size(64, 31);
            this.btn2Cancel.TabIndex = 3;
            this.btn2Cancel.Text = "Cancel";
            this.btn2Cancel.UseVisualStyleBackColor = true;
            this.btn2Cancel.Click += new System.EventHandler(this.btn2Cancel_Click);
            // 
            // Form_HW15_Guess_userWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btn2Cancel);
            this.Controls.Add(this.btn2Enter);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.labNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_HW15_Guess_userWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNotice;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btn2Enter;
        private System.Windows.Forms.Button btn2Cancel;
    }
}