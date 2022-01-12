
namespace HW01
{
    partial class Form_HW13_DrawPaint
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
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarPenSize = new System.Windows.Forms.TrackBar();
            this.picBoxColor = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labSize = new System.Windows.Forms.Label();
            this.panelDraw.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Controls.Add(this.panel1);
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(0, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(834, 511);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labSize);
            this.panel1.Controls.Add(this.trackBarPenSize);
            this.panel1.Controls.Add(this.picBoxColor);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Location = new System.Drawing.Point(742, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 250);
            this.panel1.TabIndex = 0;
            // 
            // trackBarPenSize
            // 
            this.trackBarPenSize.Location = new System.Drawing.Point(28, 62);
            this.trackBarPenSize.Maximum = 100;
            this.trackBarPenSize.Minimum = 1;
            this.trackBarPenSize.Name = "trackBarPenSize";
            this.trackBarPenSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPenSize.Size = new System.Drawing.Size(45, 163);
            this.trackBarPenSize.TabIndex = 2;
            this.trackBarPenSize.TickFrequency = 10;
            this.trackBarPenSize.Value = 1;
            this.trackBarPenSize.ValueChanged += new System.EventHandler(this.trackBarPenSize_ValueChanged);
            // 
            // picBoxColor
            // 
            this.picBoxColor.BackColor = System.Drawing.Color.Black;
            this.picBoxColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxColor.Location = new System.Drawing.Point(0, 30);
            this.picBoxColor.Name = "picBoxColor";
            this.picBoxColor.Size = new System.Drawing.Size(80, 30);
            this.picBoxColor.TabIndex = 1;
            this.picBoxColor.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColor.Location = new System.Drawing.Point(0, 0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(80, 30);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labSize
            // 
            this.labSize.Location = new System.Drawing.Point(16, 229);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(47, 18);
            this.labSize.TabIndex = 3;
            this.labSize.Text = "1";
            this.labSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_HW13_DrawPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form_HW13_DrawPaint";
            this.Text = "Form_HW13_DrawPaint";
            this.panelDraw.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBarPenSize;
        private System.Windows.Forms.Label labSize;
    }
}