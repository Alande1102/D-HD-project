namespace platformgame
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.EnemyTwo = new System.Windows.Forms.PictureBox();
            this.EnemyOne = new System.Windows.Forms.PictureBox();
            this.VerticlePlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.HorizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticlePlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(333, 11);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(297, 143);
            this.txtScore.TabIndex = 0;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Green;
            this.Player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player.Image = global::platformgame.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(67, 657);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 49);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 10;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox21.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox21.Location = new System.Drawing.Point(143, 679);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(33, 31);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox21.TabIndex = 14;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "Coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox20.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox20.Location = new System.Drawing.Point(233, 676);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(33, 31);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox20.TabIndex = 14;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "Coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox19.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox19.Location = new System.Drawing.Point(249, 498);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(33, 31);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox19.TabIndex = 14;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "Coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox16.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox16.Location = new System.Drawing.Point(571, 548);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(33, 31);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox16.TabIndex = 14;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "Coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox15.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox15.Location = new System.Drawing.Point(116, 421);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(33, 31);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "Coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox14.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox14.Location = new System.Drawing.Point(116, 240);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(33, 31);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "Coin";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox13.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox13.Location = new System.Drawing.Point(332, 169);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "Coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox12.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox12.Location = new System.Drawing.Point(291, 169);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 31);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "Coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox11.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox11.Location = new System.Drawing.Point(249, 169);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 31);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Coin";
            // 
            // EnemyTwo
            // 
            this.EnemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.EnemyTwo.Image = global::platformgame.Properties.Resources.Monster;
            this.EnemyTwo.Location = new System.Drawing.Point(415, 582);
            this.EnemyTwo.Margin = new System.Windows.Forms.Padding(4);
            this.EnemyTwo.Name = "EnemyTwo";
            this.EnemyTwo.Size = new System.Drawing.Size(40, 49);
            this.EnemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyTwo.TabIndex = 13;
            this.EnemyTwo.TabStop = false;
            this.EnemyTwo.Tag = "enemy";
            // 
            // EnemyOne
            // 
            this.EnemyOne.BackColor = System.Drawing.Color.Transparent;
            this.EnemyOne.Image = global::platformgame.Properties.Resources.Monster;
            this.EnemyOne.Location = new System.Drawing.Point(436, 324);
            this.EnemyOne.Margin = new System.Windows.Forms.Padding(4);
            this.EnemyOne.Name = "EnemyOne";
            this.EnemyOne.Size = new System.Drawing.Size(40, 49);
            this.EnemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyOne.TabIndex = 12;
            this.EnemyOne.TabStop = false;
            this.EnemyOne.Tag = "enemy";
            // 
            // VerticlePlatform
            // 
            this.VerticlePlatform.BackColor = System.Drawing.SystemColors.ControlText;
            this.VerticlePlatform.Image = global::platformgame.Properties.Resources.platform;
            this.VerticlePlatform.Location = new System.Drawing.Point(540, 587);
            this.VerticlePlatform.Margin = new System.Windows.Forms.Padding(4);
            this.VerticlePlatform.Name = "VerticlePlatform";
            this.VerticlePlatform.Size = new System.Drawing.Size(89, 23);
            this.VerticlePlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VerticlePlatform.TabIndex = 9;
            this.VerticlePlatform.TabStop = false;
            this.VerticlePlatform.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox8.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox8.Location = new System.Drawing.Point(24, 107);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(152, 23);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // HorizontalPlatform
            // 
            this.HorizontalPlatform.BackColor = System.Drawing.SystemColors.ControlText;
            this.HorizontalPlatform.Image = global::platformgame.Properties.Resources.platform;
            this.HorizontalPlatform.Location = new System.Drawing.Point(249, 207);
            this.HorizontalPlatform.Margin = new System.Windows.Forms.Padding(4);
            this.HorizontalPlatform.Name = "HorizontalPlatform";
            this.HorizontalPlatform.Size = new System.Drawing.Size(152, 23);
            this.HorizontalPlatform.TabIndex = 7;
            this.HorizontalPlatform.TabStop = false;
            this.HorizontalPlatform.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox6.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox6.Location = new System.Drawing.Point(87, 289);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox5.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox5.Location = new System.Drawing.Point(217, 372);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(280, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox4.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox4.Location = new System.Drawing.Point(87, 459);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox3.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(217, 537);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 23);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox2.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(365, 631);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Image = global::platformgame.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(17, 714);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Purple;
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(24, 59);
            this.door.Margin = new System.Windows.Forms.Padding(4);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(40, 49);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 11;
            this.door.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox18.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox18.Location = new System.Drawing.Point(344, 334);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(33, 31);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox18.TabIndex = 14;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "Coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox17.Image = global::platformgame.Properties.Resources.coin;
            this.pictureBox17.Location = new System.Drawing.Point(233, 334);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(33, 31);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox17.TabIndex = 14;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "Coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(643, 750);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::platformgame.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(645, 752);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.EnemyTwo);
            this.Controls.Add(this.EnemyOne);
            this.Controls.Add(this.VerticlePlatform);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.HorizontalPlatform);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Level1";
            this.Text = "Platform game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticlePlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox HorizontalPlatform;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox VerticlePlatform;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox EnemyOne;
        private System.Windows.Forms.PictureBox EnemyTwo;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

