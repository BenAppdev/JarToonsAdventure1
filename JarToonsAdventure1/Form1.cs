using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarToonsAdventure1
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 6;

        int enemyOneSpeed = 3;
        int enemyTwoSpeed = 5;
        int flipImage = 0;
        

        public Form1()
        {
            InitializeComponent();
        }


        
        private void MyGameTimerEvent(object sender, EventArgs e)
        {
            
            txtScore.Text = "Score: " + score;

            player.Top += jumpSpeed;


            if (goLeft == true)
            {
                //player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                player.Left -= playerSpeed;
                
                //PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)

            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
                //player.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            if(jumping == true && force < 0)
            {
                jumping = false;
                //player.Image.
            }

            if(jumping == true)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
            {
                jumpSpeed = 15;
            }





            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                            
                        }

                        x.BringToFront();
                    }

                    if((string)x.Tag == "coin")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if((string)x.Tag == "enemy")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "You were killed in your journey";
                        }

                    }
                }

            }

            horizontalPlatform.Left -= horizontalSpeed;

            if(horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if(verticalPlatform.Top < 400 || verticalPlatform.Top > 600)
            {
                verticalSpeed = -verticalSpeed;
            }

            enemyOne.Left -= enemyOneSpeed;

            if(enemyOne.Left < pictureBox4.Left || enemyOne.Left + enemyOne.Width> pictureBox4.Left + pictureBox4.Width)
            {
                enemyOneSpeed = - enemyOneSpeed;
            }

            enemyTwo.Left += enemyTwoSpeed;

            if (enemyTwo.Left < pictureBox5.Left || enemyTwo.Left + enemyTwo.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "You fell to your death";
            }

            if(player.Bounds.IntersectsWith(door.Bounds) && score >= 10)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Quest is Complete";
            }
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "Collect all the Coins";
            }

            if(score == 10)
            {
                door2.Visible = true;
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {
            player.Image = Image.FromFile("JarToonsAdventure1.Properties.Resources.chr_Jessie_64_R");
            //myImage = new Bitmap(JarToonsAdventure1.Properties.Resources.chr_Jessie_64_R);
            //player.Image = (Image ) (myImage);
        }

        private void door_Click(object sender, EventArgs e)
        {

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



        }

        private void RestartGame()
        {

            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }


            // reset the position of player platform and enemies


            player.Left = 40;
            player.Top = 650;

            enemyOne.Left = 390;
            enemyTwo.Left = 330;

            horizontalPlatform.Left = 275;
            verticalPlatform.Top = 600;

            door2.Visible = false;

            gameTimer.Start();
        }
    }
}
