
namespace HW01
{
    partial class Form_Game_FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labScore = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myBird = new System.Windows.Forms.PictureBox();
            this.sky = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe2Bottom = new System.Windows.Forms.PictureBox();
            this.pipe2Top = new System.Windows.Forms.PictureBox();
            this.pipe1Bottom = new System.Windows.Forms.PictureBox();
            this.pipe1Top = new System.Windows.Forms.PictureBox();
            this.labSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1Top)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.BackColor = System.Drawing.Color.Gold;
            this.labScore.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.Location = new System.Drawing.Point(94, 0);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(73, 21);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Score: ";
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.BackColor = System.Drawing.Color.Transparent;
            this.labMessage.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMessage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labMessage.Location = new System.Drawing.Point(51, 177);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(411, 72);
            this.labMessage.TabIndex = 4;
            this.labMessage.Text = "Click EnterKey to start game\r\n\r\nPress Space or Left_Click_Mouse to fly";
            this.labMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(93, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Watch out! Speed-up by the score!";
            // 
            // myBird
            // 
            this.myBird.BackColor = System.Drawing.Color.Transparent;
            this.myBird.Image = global::HW01.Properties.Resources.Frame_1;
            this.myBird.Location = new System.Drawing.Point(80, 110);
            this.myBird.Name = "myBird";
            this.myBird.Size = new System.Drawing.Size(50, 50);
            this.myBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myBird.TabIndex = 0;
            this.myBird.TabStop = false;
            // 
            // sky
            // 
            this.sky.Image = global::HW01.Properties.Resources.groundtop;
            this.sky.Location = new System.Drawing.Point(-15, -85);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(552, 138);
            this.sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sky.TabIndex = 8;
            this.sky.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::HW01.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-15, 412);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(552, 138);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // pipe2Bottom
            // 
            this.pipe2Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pipe2Bottom.Image = global::HW01.Properties.Resources.pipe;
            this.pipe2Bottom.Location = new System.Drawing.Point(149, 300);
            this.pipe2Bottom.Name = "pipe2Bottom";
            this.pipe2Bottom.Size = new System.Drawing.Size(65, 250);
            this.pipe2Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2Bottom.TabIndex = 6;
            this.pipe2Bottom.TabStop = false;
            this.pipe2Bottom.Visible = false;
            // 
            // pipe2Top
            // 
            this.pipe2Top.BackColor = System.Drawing.Color.Transparent;
            this.pipe2Top.Image = global::HW01.Properties.Resources.pipedown;
            this.pipe2Top.Location = new System.Drawing.Point(149, -60);
            this.pipe2Top.Name = "pipe2Top";
            this.pipe2Top.Size = new System.Drawing.Size(65, 200);
            this.pipe2Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2Top.TabIndex = 5;
            this.pipe2Top.TabStop = false;
            this.pipe2Top.Visible = false;
            // 
            // pipe1Bottom
            // 
            this.pipe1Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pipe1Bottom.Image = global::HW01.Properties.Resources.pipe;
            this.pipe1Bottom.Location = new System.Drawing.Point(340, 300);
            this.pipe1Bottom.Name = "pipe1Bottom";
            this.pipe1Bottom.Size = new System.Drawing.Size(65, 250);
            this.pipe1Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1Bottom.TabIndex = 2;
            this.pipe1Bottom.TabStop = false;
            // 
            // pipe1Top
            // 
            this.pipe1Top.BackColor = System.Drawing.Color.Transparent;
            this.pipe1Top.Image = global::HW01.Properties.Resources.pipedown;
            this.pipe1Top.Location = new System.Drawing.Point(340, -60);
            this.pipe1Top.Name = "pipe1Top";
            this.pipe1Top.Size = new System.Drawing.Size(65, 200);
            this.pipe1Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1Top.TabIndex = 1;
            this.pipe1Top.TabStop = false;
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.BackColor = System.Drawing.Color.Gold;
            this.labSpeed.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSpeed.Location = new System.Drawing.Point(305, 0);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(76, 21);
            this.labSpeed.TabIndex = 10;
            this.labSpeed.Text = "Speed: ";
            // 
            // Form_Game_FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::HW01.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labSpeed);
            this.Controls.Add(this.myBird);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe2Bottom);
            this.Controls.Add(this.pipe2Top);
            this.Controls.Add(this.pipe1Bottom);
            this.Controls.Add(this.pipe1Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Game_FlappyBird";
            this.Text = "Flappy Bird  (no one can get 21)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.myBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myBird;
        private System.Windows.Forms.PictureBox pipe1Top;
        private System.Windows.Forms.PictureBox pipe1Bottom;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.PictureBox pipe2Bottom;
        private System.Windows.Forms.PictureBox pipe2Top;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox sky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSpeed;
    }
}