﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace platformgame
{
    public partial class Level1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver, Win = false;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;


        Level2 Level_2 = new Level2();

        public Level1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            Player.Top += jumpSpeed;

            if(goLeft == true)
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

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "platform")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;

                            if((string)x.Name == "HorizontalPlatform" && goLeft == false || (string)x.Name == "HorizontalPlatform" && goRight == false)
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

            HorizontalPlatform.Left -= horizontalSpeed;

            if(HorizontalPlatform.Left < 0 || HorizontalPlatform.Left + HorizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            VerticlePlatform.Top += verticalSpeed;

            if (VerticlePlatform.Top < 195 || VerticlePlatform.Top > 477)
            {
                verticalSpeed = -verticalSpeed;
            }

            EnemyOne.Left -= enemyOneSpeed;
            if(EnemyOne.Left < pictureBox5.Left || EnemyOne.Left + EnemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            EnemyTwo.Left -= enemyTwoSpeed;
            if (EnemyTwo.Left < pictureBox2.Left || EnemyTwo.Left + EnemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if (Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "score: " + score + Environment.NewLine + "You fell!";
            }

            if (Player.Bounds.IntersectsWith(door.Bounds) && score == 11)
            {
                GameTimer.Stop();
                Win = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "All coins collected" + Environment.NewLine + "Press enter for next level";
            }
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "collect the coins";
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if ( e.KeyCode == Keys.Right)
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
            // Go to level 2 When you win
            if (e.KeyCode == Keys.Enter && Win == true)
            {
                Level_2.Show();
                Level_2.Location = this.Location;
                Level_2.TopMost = true;
                this.Hide();
            }
        }
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            Player.Left = 52;
            Player.Top = 525;

            EnemyOne.Left = 327;
            EnemyOne.Top = 256;

            EnemyTwo.Left = 274;
            EnemyTwo.Top = 470;

            VerticlePlatform.Top = 477;
            HorizontalPlatform.Left = 187;

            GameTimer.Start();
        }
    }
}