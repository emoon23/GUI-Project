namespace SleighRush
{
    partial class GameScreen
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
            this.Start = new System.Windows.Forms.Button();
            this.Leader = new System.Windows.Forms.Button();
            this.Distance = new System.Windows.Forms.Label();
            this.distance1 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.skyTrack2 = new System.Windows.Forms.PictureBox();
            this.skyTrack1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(130, 484);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 59);
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Leader
            // 
            this.Leader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Leader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leader.Location = new System.Drawing.Point(266, 484);
            this.Leader.Name = "Leader";
            this.Leader.Size = new System.Drawing.Size(130, 59);
            this.Leader.TabIndex = 1;
            this.Leader.TabStop = false;
            this.Leader.Text = "Leaderboard";
            this.Leader.UseVisualStyleBackColor = true;
            this.Leader.Click += new System.EventHandler(this.LeaderboardButtonClicked);
            // 
            // Distance
            // 
            this.Distance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Distance.AutoSize = true;
            this.Distance.BackColor = System.Drawing.Color.Transparent;
            this.Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.Color.Crimson;
            this.Distance.Location = new System.Drawing.Point(142, 456);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(118, 25);
            this.Distance.TabIndex = 2;
            this.Distance.Text = "Distance: ";
            // 
            // distance1
            // 
            this.distance1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distance1.AutoSize = true;
            this.distance1.BackColor = System.Drawing.Color.Transparent;
            this.distance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance1.ForeColor = System.Drawing.Color.Crimson;
            this.distance1.Location = new System.Drawing.Point(261, 456);
            this.distance1.Name = "distance1";
            this.distance1.Size = new System.Drawing.Size(38, 25);
            this.distance1.TabIndex = 3;
            this.distance1.Text = "00";
            // 
            // tip
            // 
            this.tip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tip.AutoSize = true;
            this.tip.BackColor = System.Drawing.Color.Transparent;
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.ForeColor = System.Drawing.Color.Crimson;
            this.tip.Location = new System.Drawing.Point(99, 546);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(317, 50);
            this.tip.TabIndex = 4;
            this.tip.Text = "Use Left and Right arrows\r\nIt is always good to warm up.\r\n";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.skyTrack2);
            this.panel1.Controls.Add(this.skyTrack1);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 5;
            // 
            // player
            // 
            this.player.Image = global::SleighRush.Properties.Resources.sleigh;
            this.player.Location = new System.Drawing.Point(161, 286);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 101);
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::SleighRush.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(153, 254);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::SleighRush.Properties.Resources.satellite;
            this.AI2.Location = new System.Drawing.Point(294, 85);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::SleighRush.Properties.Resources.airballoon;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // skyTrack2
            // 
            this.skyTrack2.BackColor = System.Drawing.Color.Transparent;
            this.skyTrack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skyTrack2.Image = global::SleighRush.Properties.Resources.starnight3;
            this.skyTrack2.Location = new System.Drawing.Point(-3, -222);
            this.skyTrack2.Name = "skyTrack2";
            this.skyTrack2.Size = new System.Drawing.Size(1000, 1500);
            this.skyTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skyTrack2.TabIndex = 1;
            this.skyTrack2.TabStop = false;
            // 
            // skyTrack1
            // 
            this.skyTrack1.BackColor = System.Drawing.Color.Transparent;
            this.skyTrack1.Image = global::SleighRush.Properties.Resources.starnight21;
            this.skyTrack1.Location = new System.Drawing.Point(-2, -638);
            this.skyTrack1.Name = "skyTrack1";
            this.skyTrack1.Size = new System.Drawing.Size(1100, 1500);
            this.skyTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skyTrack1.TabIndex = 0;
            this.skyTrack1.TabStop = false;
            this.skyTrack1.Click += new System.EventHandler(this.skyTrack1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(214, 608);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 36);
            this.Exit.TabIndex = 6;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 656);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.distance1);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Leader);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameScreen";
            this.Text = "Sleigh Rush";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Leader;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label distance1;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox skyTrack1;
        private System.Windows.Forms.PictureBox skyTrack2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
    }
}