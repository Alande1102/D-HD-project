using System;
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
        //initializing all the boolean variables as false
        bool goLeft, goRight, jumping, isGameOver, Win = false;
        //initializing the int variables
        int jumpSpeed;
        //force acts as the gravity
        int force;
        int score = 0;
        int playerSpeed = 7;
        //the two ints control the platform speeds
        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        //these two control the enemy speeds
        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;




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
            //initializes the text
            txtScore.Text = "Score: " + score + Environment.NewLine + "Collect the coins!" + Environment.NewLine + "(Press esc to exit to Main Menu";
            //allows the player to jump
            Player.Top += jumpSpeed;

            //the following if statements control the players movement
            if(goLeft == true)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
            }
            //this if statement stops the player from jumping once the force becomes negative
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            //when jumping the player's jump slows as the jumpspeed reduces
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            //the following foreach controls the player's interaction with everything in the level
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    //This if statement allows the player to use the platform 
                    if ((string)x.Tag == "platform")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;
                            //this if statement allows the player to move with the horizontal platform
                            if((string)x.Name == "HorizontalPlatform" && goLeft == false || (string)x.Name == "HorizontalPlatform" && goRight == false)
                            {
                                Player.Left -= horizontalSpeed;
                            }
                        }
                        x.BringToFront();
                    }
                    //this allows the player to collect the coins
                    if ((string)x.Tag == "Coin")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    //this 'kills' the player if they collide with an enemy
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
            //moves the horizontal platform accross the screen
            HorizontalPlatform.Left -= horizontalSpeed;

            //this reverses the direction of the platform when it hits the edge of the screen
            if(HorizontalPlatform.Left < 0 || HorizontalPlatform.Left + HorizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            //moves the vertical platform up
            VerticlePlatform.Top += verticalSpeed;

            //reverses the direction of the vertical platform when it reaches the number listed on the y axis
            if (VerticlePlatform.Top < 195 || VerticlePlatform.Top > 477)
            {
                verticalSpeed = -verticalSpeed;
            }

            //controls enemy one's movement
            EnemyOne.Left -= enemyOneSpeed;
            if(EnemyOne.Left < pictureBox5.Left || EnemyOne.Left + EnemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            //control's enemy two's movement
            EnemyTwo.Left -= enemyTwoSpeed;
            if (EnemyTwo.Left < pictureBox2.Left || EnemyTwo.Left + EnemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            //stops the game if the player falls off the map
            if (Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "score: " + score + Environment.NewLine + "You fell!";
            }

            //allows the player to beat the level if they touch the door after collecting all the coins
            if (Player.Bounds.IntersectsWith(door.Bounds) && score == 11)
            {
                GameTimer.Stop();
                Win = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "All coins collected" + Environment.NewLine + "Press enter for next level";
            }

            //if the player is currently playing the game then the following text is displayed in the top right
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "collect the coins" + Environment.NewLine + "(Press esc to exit to Main Menu)";
            }
        }

        //the following controls the players movement using the keyboard
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

        //the following stops the playes movement if the key is no longer being pressed
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
            //allows the level to be restarted if the player dies
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }
            // Go to level 2 When you win
            if (e.KeyCode == Keys.Enter && Win == true)
            {
                Level2 Level_2 = new Level2();
                Level_2.Show();
                Level_2.Location = this.Location;
                Level_2.TopMost = true;
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
            //reset the variables when the player restarts the level
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            txtScore.Text = "Score: " + score + Environment.NewLine + "(Press esc to exit to Main Menu)";
            
            //makes any coins that were colloected visible again
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //puts the player back in the start position
            Player.Left = 52;
            Player.Top = 525;

            //puts the enemies back in their start positions
            EnemyOne.Left = 327;
            EnemyOne.Top = 256;

            EnemyTwo.Left = 274;
            EnemyTwo.Top = 470;

            //puts the platforms back in their start positions
            VerticlePlatform.Top = 477;
            HorizontalPlatform.Left = 187;

            GameTimer.Start();
        }
    }
}
