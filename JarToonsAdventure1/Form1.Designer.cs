
namespace JarToonsAdventure1
{
    partial class Form1
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.door2 = new System.Windows.Forms.PictureBox();
            this.logoJartoons = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.verticalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.horizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoJartoons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(385, 9);
            this.txtScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(319, 131);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score:0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MyGameTimerEvent);
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Transparent;
            this.door2.Image = global::JarToonsAdventure1.Properties.Resources.door_2;
            this.door2.Location = new System.Drawing.Point(22, 286);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(73, 60);
            this.door2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door2.TabIndex = 30;
            this.door2.TabStop = false;
            this.door2.Tag = "door";
            this.door2.Visible = false;
            // 
            // logoJartoons
            // 
            this.logoJartoons.BackgroundImage = global::JarToonsAdventure1.Properties.Resources.Jartoons_logo;
            this.logoJartoons.Location = new System.Drawing.Point(18, 12);
            this.logoJartoons.Name = "logoJartoons";
            this.logoJartoons.Size = new System.Drawing.Size(256, 88);
            this.logoJartoons.TabIndex = 29;
            this.logoJartoons.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.DarkBlue;
            this.enemyTwo.Location = new System.Drawing.Point(547, 447);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(30, 40);
            this.enemyTwo.TabIndex = 13;
            this.enemyTwo.TabStop = false;
            this.enemyTwo.Tag = "enemy";
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.DarkBlue;
            this.enemyOne.Location = new System.Drawing.Point(220, 568);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(30, 40);
            this.enemyOne.TabIndex = 12;
            this.enemyOne.TabStop = false;
            this.enemyOne.Tag = "enemy";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.Image = global::JarToonsAdventure1.Properties.Resources.door_1;
            this.door.Location = new System.Drawing.Point(22, 286);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(73, 60);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 11;
            this.door.TabStop = false;
            this.door.Tag = "door";
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // verticalPlatform
            // 
            this.verticalPlatform.BackColor = System.Drawing.Color.Transparent;
            this.verticalPlatform.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.verticalPlatform.Location = new System.Drawing.Point(578, 597);
            this.verticalPlatform.Name = "verticalPlatform";
            this.verticalPlatform.Size = new System.Drawing.Size(128, 32);
            this.verticalPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verticalPlatform.TabIndex = 9;
            this.verticalPlatform.TabStop = false;
            this.verticalPlatform.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.pictureBox8.Location = new System.Drawing.Point(12, 346);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(145, 30);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // horizontalPlatform
            // 
            this.horizontalPlatform.BackColor = System.Drawing.Color.Transparent;
            this.horizontalPlatform.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.horizontalPlatform.Location = new System.Drawing.Point(402, 316);
            this.horizontalPlatform.Name = "horizontalPlatform";
            this.horizontalPlatform.Size = new System.Drawing.Size(175, 39);
            this.horizontalPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horizontalPlatform.TabIndex = 7;
            this.horizontalPlatform.TabStop = false;
            this.horizontalPlatform.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.pictureBox6.Location = new System.Drawing.Point(123, 430);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(140, 44);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.pictureBox5.Location = new System.Drawing.Point(305, 497);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(276, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::JarToonsAdventure1.Properties.Resources.floor_grass2;
            this.pictureBox4.Location = new System.Drawing.Point(84, 615);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(418, 32);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::JarToonsAdventure1.Properties.Resources.floor_grass;
            this.pictureBox2.Location = new System.Drawing.Point(559, 730);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JarToonsAdventure1.Properties.Resources.floor_grass2;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 791);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Enabled = false;
            this.pictureBox10.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox10.Location = new System.Drawing.Point(470, 268);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Enabled = false;
            this.pictureBox17.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox17.Location = new System.Drawing.Point(209, 390);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(41, 42);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Enabled = false;
            this.pictureBox15.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox15.Location = new System.Drawing.Point(398, 449);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(41, 42);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 27;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Enabled = false;
            this.pictureBox14.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox14.Location = new System.Drawing.Point(322, 449);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(41, 42);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Enabled = false;
            this.pictureBox20.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox20.Location = new System.Drawing.Point(287, 568);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(41, 42);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "coin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox3.Location = new System.Drawing.Point(173, 566);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox9.Location = new System.Drawing.Point(96, 566);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Enabled = false;
            this.pictureBox12.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox12.Location = new System.Drawing.Point(630, 682);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(41, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Enabled = false;
            this.pictureBox18.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox18.Location = new System.Drawing.Point(176, 743);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(41, 42);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 24;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Enabled = false;
            this.pictureBox13.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox13.Location = new System.Drawing.Point(322, 743);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(41, 42);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Enabled = false;
            this.pictureBox11.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox11.Location = new System.Drawing.Point(442, 743);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(41, 42);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = global::JarToonsAdventure1.Properties.Resources.scroll_;
            this.pictureBox7.Location = new System.Drawing.Point(568, 682);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::JarToonsAdventure1.Properties.Resources.chr_Jessie_64;
            this.player.InitialImage = global::JarToonsAdventure1.Properties.Resources.chr_Jessie_64;
            this.player.Location = new System.Drawing.Point(43, 696);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            this.player.Tag = "Player";
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(718, 826);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.logoJartoons);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.door);
            this.Controls.Add(this.verticalPlatform);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.horizontalPlatform);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Jar-Toons Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoJartoons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox horizontalPlatform;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox verticalPlatform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox logoJartoons;
        private System.Windows.Forms.PictureBox door2;
    }
}

