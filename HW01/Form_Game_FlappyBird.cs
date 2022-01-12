using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class Form_Game_FlappyBird : Form
    {
        int SpeedOfBird = 6;
        int SpeedOfPipe = 4;
        int myScore =0;
        Random RND = new Random();
        public Form_Game_FlappyBird()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            GameTimer.Stop();
            pipe2Top.Left = 700;
            pipe2Bottom.Left = 700;
            pipe2Top.Visible = true;
            pipe2Bottom.Visible = true;
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            // make pipes and bird auto move.
            myBird.Top += SpeedOfBird;
            pipe1Top.Left -= SpeedOfPipe;
            pipe1Bottom.Left -= SpeedOfPipe;
            pipe2Top.Left -= SpeedOfPipe;
            pipe2Bottom.Left -= SpeedOfPipe;

            // get point after the bird pass through the pipe
            if (pipe1Top.Right < 0)
            {
                GetPoint(pipe1Top,pipe1Bottom);
            }
            if (pipe2Top.Right < 0)
            {
                GetPoint(pipe2Top, pipe2Bottom);
            }

            // end the game after hit
            if (myBird.Bounds.IntersectsWith(pipe1Top.Bounds) || 
                myBird.Bounds.IntersectsWith(pipe1Bottom.Bounds) ||
                myBird.Bounds.IntersectsWith(pipe2Top.Bounds) ||
                myBird.Bounds.IntersectsWith(pipe2Bottom.Bounds) ||
                myBird.Bounds.IntersectsWith(ground.Bounds) ||
                myBird.Bounds.IntersectsWith(sky.Bounds))
            {
                GameTimer.Stop();
                labMessage.Visible = true;
                labMessage.Text = "Game Over!"  + "\nPress Enter key to restart.";
            }  
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                myBird.Image = Properties.Resources.frame_3;
                SpeedOfBird = -6;
            }

            if(e.KeyCode == Keys.Enter)
            {
                GameReset();
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                myBird.Image = Properties.Resources.Frame_1;
                SpeedOfBird = 6;
            }
        }

        // after press Enter, reset the game
        private void GameReset()
        {
            SpeedOfBird = 6;
            SpeedOfPipe = 4;
            myScore = 0;
            labScore.Text = "Score: " + myScore;
            labSpeed.Text = "Speed: 1";
            labMessage.Visible = false;
            GameTimer.Start();
            myBird.Left = 80;
            myBird.Top = 110;
            pipe1Top.Left = 340;
            pipe1Top.Top = -60;
            pipe1Bottom.Left = 340;
            pipe1Bottom.Top = 300;
            pipe2Top.Left = 700;
            pipe2Top.Top = -60;
            pipe2Bottom.Left = 700;
            pipe2Bottom.Top = 300;
        }

        // get point , repeat the pipe and speedup
        private void GetPoint(Control a, Control b)
        {
            a.Top = -60 + RND.Next(-75, 75);
            b.Top = a.Bottom + 150 + RND.Next(-10, 10);
            a.Left = 600;
            b.Left = 600;
            myScore++;
            labScore.Text = "Score: " + myScore;
            SpeedOfPipe = 5 + (myScore/2);
            labSpeed.Text = "Speed: " + (SpeedOfPipe-4);
        }

        private void MouseIsDown(object sender, MouseEventArgs e)
        {
            myBird.Image = Properties.Resources.frame_3;
            SpeedOfBird = -6;
        }

        private void MouseIsUp(object sender, MouseEventArgs e)
        {
            myBird.Image = Properties.Resources.Frame_1;
            SpeedOfBird = 6;
        }
    }
}
