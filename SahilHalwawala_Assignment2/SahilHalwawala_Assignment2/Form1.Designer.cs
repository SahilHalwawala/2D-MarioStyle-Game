namespace SahilHalwawala_Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Platform1 = new PictureBox();
            player = new PictureBox();
            Enemy2 = new PictureBox();
            Coin1 = new PictureBox();
            Enemy1 = new PictureBox();
            Obstacle = new PictureBox();
            Platform2 = new PictureBox();
            EndGame = new PictureBox();
            Coin4 = new PictureBox();
            Coin3 = new PictureBox();
            Coin2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            LabelForTime = new Label();
            LabelForScore = new Label();
            ((System.ComponentModel.ISupportInitialize)Platform1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EndGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
            SuspendLayout();
            // 
            // Platform1
            // 
            Platform1.BackColor = Color.FromArgb(128, 64, 64);
            Platform1.Location = new Point(220, 399);
            Platform1.Name = "Platform1";
            Platform1.Size = new Size(254, 19);
            Platform1.TabIndex = 0;
            Platform1.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.Pngtree_1_;
            player.Location = new Point(0, 533);
            player.Margin = new Padding(0);
            player.Name = "player";
            player.Size = new Size(61, 70);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // Enemy2
            // 
            Enemy2.BackColor = Color.Transparent;
            Enemy2.Image = (Image)resources.GetObject("Enemy2.Image");
            Enemy2.Location = new Point(747, 272);
            Enemy2.Margin = new Padding(0);
            Enemy2.Name = "Enemy2";
            Enemy2.Size = new Size(33, 31);
            Enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy2.TabIndex = 3;
            Enemy2.TabStop = false;
            // 
            // Coin1
            // 
            Coin1.BackColor = Color.Transparent;
            Coin1.Image = Properties.Resources.dime_clipart_lg;
            Coin1.Location = new Point(284, 216);
            Coin1.Name = "Coin1";
            Coin1.Size = new Size(51, 53);
            Coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            Coin1.TabIndex = 4;
            Coin1.TabStop = false;
            // 
            // Enemy1
            // 
            Enemy1.BackColor = Color.Transparent;
            Enemy1.Image = (Image)resources.GetObject("Enemy1.Image");
            Enemy1.Location = new Point(855, 563);
            Enemy1.Margin = new Padding(0);
            Enemy1.Name = "Enemy1";
            Enemy1.Size = new Size(37, 40);
            Enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy1.TabIndex = 10;
            Enemy1.TabStop = false;
            // 
            // Obstacle
            // 
            Obstacle.Image = Properties.Resources.fence_clipart_lg;
            Obstacle.Location = new Point(272, 505);
            Obstacle.Name = "Obstacle";
            Obstacle.Size = new Size(125, 97);
            Obstacle.SizeMode = PictureBoxSizeMode.StretchImage;
            Obstacle.TabIndex = 11;
            Obstacle.TabStop = false;
            // 
            // Platform2
            // 
            Platform2.BackColor = Color.FromArgb(128, 64, 64);
            Platform2.Location = new Point(601, 306);
            Platform2.Name = "Platform2";
            Platform2.Size = new Size(271, 19);
            Platform2.TabIndex = 12;
            Platform2.TabStop = false;
            // 
            // EndGame
            // 
            EndGame.Image = Properties.Resources.elevator_clipart_lg;
            EndGame.Location = new Point(1077, 471);
            EndGame.Name = "EndGame";
            EndGame.Size = new Size(72, 131);
            EndGame.SizeMode = PictureBoxSizeMode.StretchImage;
            EndGame.TabIndex = 13;
            EndGame.TabStop = false;
            // 
            // Coin4
            // 
            Coin4.BackColor = Color.Transparent;
            Coin4.Image = Properties.Resources.dime_clipart_lg;
            Coin4.Location = new Point(994, 505);
            Coin4.Name = "Coin4";
            Coin4.Size = new Size(51, 53);
            Coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            Coin4.TabIndex = 14;
            Coin4.TabStop = false;
            // 
            // Coin3
            // 
            Coin3.BackColor = Color.Transparent;
            Coin3.Image = Properties.Resources.dime_clipart_lg;
            Coin3.Location = new Point(533, 452);
            Coin3.Name = "Coin3";
            Coin3.Size = new Size(51, 53);
            Coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            Coin3.TabIndex = 15;
            Coin3.TabStop = false;
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Transparent;
            Coin2.Image = Properties.Resources.dime_clipart_lg;
            Coin2.Location = new Point(672, 67);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(51, 53);
            Coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            Coin2.TabIndex = 16;
            Coin2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tag = " ";
            timer1.Tick += timer1_Tick;
            // 
            // LabelForTime
            // 
            LabelForTime.AutoSize = true;
            LabelForTime.Location = new Point(950, 99);
            LabelForTime.Name = "LabelForTime";
            LabelForTime.Size = new Size(50, 20);
            LabelForTime.TabIndex = 17;
            LabelForTime.Text = "label1";
            // 
            // LabelForScore
            // 
            LabelForScore.AutoSize = true;
            LabelForScore.Location = new Point(950, 54);
            LabelForScore.Name = "LabelForScore";
            LabelForScore.Size = new Size(50, 20);
            LabelForScore.TabIndex = 18;
            LabelForScore.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1160, 603);
            Controls.Add(LabelForScore);
            Controls.Add(LabelForTime);
            Controls.Add(Coin2);
            Controls.Add(Coin3);
            Controls.Add(Coin4);
            Controls.Add(EndGame);
            Controls.Add(Platform2);
            Controls.Add(Obstacle);
            Controls.Add(Enemy1);
            Controls.Add(Coin1);
            Controls.Add(Enemy2);
            Controls.Add(player);
            Controls.Add(Platform1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Platform1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EndGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Platform1;
        private PictureBox player;
        private PictureBox Enemy2;
        private PictureBox Coin1;
        private PictureBox Enemy1;
        private PictureBox Obstacle;
        private PictureBox Platform2;
        private PictureBox EndGame;
        private PictureBox Coin4;
        private PictureBox Coin3;
        private PictureBox Coin2;
        private System.Windows.Forms.Timer timer1;
        private Label LabelForTime;
        private Label LabelForScore;
    }
}
