using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//For comments on how the following code works, please see Level1.cs
//The following code is reused for each level and therefore the comments would be identical.
//The only differences are the positions of the platforms and enemies, and the amount of platforms/coins used.

namespace platformgame
{
    public partial class Level4 : Form
    {
        bool goLeft, goRight, jumping, isGameOver, Win = false;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;





        public Level4()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score + Environment.NewLine + "Press esc to exit to Main Menu";

            Player.Top += jumpSpeed;

            if (goLeft == true)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "platform")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;

                            if ((string)x.Name == "HorizontalPlatform" && goLeft == false || (string)x.Name == "HorizontalPlatform" && goRight == false)
                            {
                                Player.Left -= horizontalSpeed;
                            }
                        }
                        x.BringToFront();
                    }
                    if ((string)x.Tag == "Coin")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag == "enemy")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {

                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "You were Killed";
                            GameTimer.Stop();
                        }
                    }
                }
            }


            VerticlePlatform.Top += verticalSpeed;

            if (VerticlePlatform.Top < 380 || VerticlePlatform.Top > 550)
            {
                verticalSpeed = -verticalSpeed;
            }

            EnemyOne.Left += enemyOneSpeed;
            if (EnemyOne.Left < pictureBox1.Left || EnemyOne.Left + EnemyOne.Width > pictureBox1.Left + pictureBox1.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }



            if (Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "score: " + score + Environment.NewLine + "You fell!";
            }

            if (Player.Bounds.IntersectsWith(door.Bounds) && score == 12)
            {
                GameTimer.Stop();
                Win = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "All coins collected" + Environment.NewLine + "Press enter for next level";
            }
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "collect the coins" + Environment.NewLine + "(Press esc to exit to Main Menu)";
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }
            // Go to level 5 When you win
            if (e.KeyCode == Keys.Enter && Win == true)
             {
               Level5 Level_5 = new Level5();
               Level_5.Show();
               Level_5.Location = this.Location;
               Level_5.TopMost = true;
             this.Close();
             }
            //press esc to get back to main menu
            if (e.KeyCode == Keys.Escape && Win == false)
            {
                MainMenu main = new MainMenu();
                main.Show();
                main.Location = this.Location;
                main.TopMost = true;
                this.Close();
            }
        }
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score + Environment.NewLine + "Press esc to exit to Main Menu";
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            Player.Left = 16;
            Player.Top = 525;

            EnemyOne.Left = 140;

            VerticlePlatform.Top = 477;

            GameTimer.Start();
        }
    }
}
