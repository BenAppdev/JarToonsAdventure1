using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;




namespace JarToonsAdventure1
{
    //public void playExclamation()
    //{
    //    SystemSounds.Exclamation.Play();
    //}

    

    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 10;

        int horizontalSpeed = 5;
        int verticalSpeed = 6;

        int enemyOneSpeed = 3;
        int enemyTwoSpeed = 5;
        int flipImage = 0;
        int animCount = 0;
        int playsoundOnce = 0;
        
        
        
        //Music And Sounds
        private void playMainMusic()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\sfx_Music.wav");
            player.Play();
        }
        private void playJump()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\sfx_Jump01.wav");
            player.Play();
        }
        private void playCoin()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\sfx_Coin02.wav");
            player.Play();
        }
        private void playDoorOpen()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\sfx_Whoosh.wav");
            player.Play();
        }
        private void playLevelEnd()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\sfx_boodoodaloop.wav");
            player.Play();
        }

        // End Of Sounds


        public Form1()
        {
            InitializeComponent();
            //playMainMusic();
            axWindowsMediaPlayer1.URL = @"C:\Users\benjamin\source\repos\JarToonsAdventure1\JarToonsAdventure1\bin\Debug\JartoonsSong.wav";
            
        }


        //Game Starts Here///////////////////////////
        private void MyGameTimerEvent(object sender, EventArgs e)
        {


            txtScore.Text = "Score: " + score;
            //player.Refresh();

            

            player.Top += jumpSpeed;


            if (goLeft == true)
            {
                
                player.Left -= playerSpeed;
                flipImage = 2;
                lbl_flip.Text = $"{flipImage}";
                animCount++;
                

            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
                animCount++;
                flipImage = 1;
                lbl_flip.Text = $"{flipImage}";
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
                
                
            }

            if (jumping == true)
            {
                jumpSpeed = -35;
                force -= 3;
                playJump();//Sound FX
            }
            else
            {
                jumpSpeed = 35;
            }


            if (animCount == 7)
            {
                animCount = 0;
            }

            if (goRight == false && goLeft == false && jumping == false)
            {
                animCount = 1;
            }




            ////////// Jessie Image Animations//////////////////
            lbl_animCount.Text = $"{ animCount}";
            //pb_animCount.Image = (JarToonsAdventure1.Properties.Resources.animCount_05);

            //var myflipsprite = (player.Image);

            //currentSprite = thesprite that is currently drawn


            var img01 = JarToonsAdventure1.Properties.Resources.animCount_01;
            var img02 = JarToonsAdventure1.Properties.Resources.animCount_02;
            var img03 = JarToonsAdventure1.Properties.Resources.animCount_03;
            var img04 = JarToonsAdventure1.Properties.Resources.animCount_04;
            var img05 = JarToonsAdventure1.Properties.Resources.animCount_05;
            var img06 = JarToonsAdventure1.Properties.Resources.animCount_06;
            

            /// Flip Character Left or Right
            if (animCount == 1) { player.Image = (img01); };
            if (animCount == 2) { player.Image = (img02); };
            if (animCount == 3) { player.Image = (img03); };
            if (animCount == 4) { player.Image = (img04); };
            if (animCount == 5) { player.Image = (img05); };
            if (animCount == 6) { player.Image = (img06); };

            if (flipImage == 2)
            {
                if (animCount == 1 ) { img01.RotateFlip(RotateFlipType.Rotate180FlipY); };
                if (animCount == 2 ) { img02.RotateFlip(RotateFlipType.Rotate180FlipY); };
                if (animCount == 3 ) { img03.RotateFlip(RotateFlipType.Rotate180FlipY); };
                if (animCount == 4 ) { img04.RotateFlip(RotateFlipType.Rotate180FlipY); };
                if (animCount == 5 ) { img05.RotateFlip(RotateFlipType.Rotate180FlipY); };
                if (animCount == 6 ) { img06.RotateFlip(RotateFlipType.Rotate180FlipY); };
            }



            //if (i == 5) { var tempimage1 = (JarToonsAdventure1.Properties.Resources.animCount_05); };

            /////////////////////////////////////////////////////

            foreach (Control x in this.Controls)
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
                            playCoin();
                            
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

            if(verticalPlatform.Top < 200 || verticalPlatform.Top > 750)
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

                playLevelEnd();
                txtScore.Text = "Score: " + score + Environment.NewLine + "Quest is Complete";
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                gameTimer.Stop();
                isGameOver = true;
                
            }
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "Collect all the Coins";
            }

            if(score == 10)
            {
                door2.Visible = true;
                playsoundOnce++;

            }

            if(playsoundOnce == 1)///This allows the Open door sound to only be played once
            {
                playDoorOpen();
                playsoundOnce++;
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

        }

        private void door_Click(object sender, EventArgs e)
        {

        }

        private void lbl_animCount_Click(object sender, EventArgs e)
        {

        }

        private void pb_animCount_Click(object sender, EventArgs e)
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

            enemyOne.Left = 322;
            enemyOne.Top = 490;
            enemyTwo.Left = 535;
            enemyTwo.Top = 331;


            horizontalPlatform.Left = 275;
            verticalPlatform.Top = 600;

            door2.Visible = false;

            gameTimer.Start();
        }
    }
}
