
namespace HW01
{
    partial class FormHW01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHW01));
            this.textCnName = new System.Windows.Forms.TextBox();
            this.textEnName = new System.Windows.Forms.TextBox();
            this.textZodiac = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.labelCnName = new System.Windows.Forms.Label();
            this.labelEnName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCnName
            // 
            this.textCnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textCnName.Location = new System.Drawing.Point(262, 29);
            this.textCnName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCnName.Name = "textCnName";
            this.textCnName.Size = new System.Drawing.Size(163, 36);
            this.textCnName.TabIndex = 0;
            // 
            // textEnName
            // 
            this.textEnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textEnName.Location = new System.Drawing.Point(262, 80);
            this.textEnName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEnName.Name = "textEnName";
            this.textEnName.Size = new System.Drawing.Size(163, 36);
            this.textEnName.TabIndex = 1;
            // 
            // textZodiac
            // 
            this.textZodiac.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textZodiac.Location = new System.Drawing.Point(262, 183);
            this.textZodiac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textZodiac.Name = "textZodiac";
            this.textZodiac.Size = new System.Drawing.Size(163, 36);
            this.textZodiac.TabIndex = 3;
            // 
            // textGender
            // 
            this.textGender.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textGender.Location = new System.Drawing.Point(262, 131);
            this.textGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(163, 36);
            this.textGender.TabIndex = 2;
            // 
            // labelCnName
            // 
            this.labelCnName.AutoSize = true;
            this.labelCnName.BackColor = System.Drawing.Color.Transparent;
            this.labelCnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCnName.ForeColor = System.Drawing.Color.Orange;
            this.labelCnName.Location = new System.Drawing.Point(87, 29);
            this.labelCnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCnName.Name = "labelCnName";
            this.labelCnName.Size = new System.Drawing.Size(64, 24);
            this.labelCnName.TabIndex = 4;
            this.labelCnName.Text = "姓名:";
            // 
            // labelEnName
            // 
            this.labelEnName.AutoSize = true;
            this.labelEnName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEnName.ForeColor = System.Drawing.Color.Orange;
            this.labelEnName.Location = new System.Drawing.Point(87, 80);
            this.labelEnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnName.Name = "labelEnName";
            this.labelEnName.Size = new System.Drawing.Size(144, 24);
            this.labelEnName.TabIndex = 5;
            this.labelEnName.Text = "English Name:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGender.ForeColor = System.Drawing.Color.Orange;
            this.labelGender.Location = new System.Drawing.Point(87, 131);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 24);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "性別:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(87, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "星座:";
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(91, 229);
            this.btnHello.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(136, 46);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(262, 229);
            this.btnHi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(136, 46);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // FormHW01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 306);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEnName);
            this.Controls.Add(this.labelCnName);
            this.Controls.Add(this.textZodiac);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textEnName);
            this.Controls.Add(this.textCnName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHW01";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCnName;
        private System.Windows.Forms.TextBox textEnName;
        private System.Windows.Forms.TextBox textZodiac;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.Label labelCnName;
        private System.Windows.Forms.Label labelEnName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}

