namespace T_Rex_Endless_Runner_Project
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
            pictureBox1 = new PictureBox();
            trex = new PictureBox();
            pictureBox4 = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-10, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(817, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trex
            // 
            trex.Image = Properties.Resources.running;
            trex.Location = new Point(86, 366);
            trex.Name = "trex";
            trex.Size = new Size(40, 43);
            trex.SizeMode = PictureBoxSizeMode.AutoSize;
            trex.TabIndex = 1;
            trex.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.obstacle_2;
            pictureBox4.Location = new Point(498, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            pictureBox4.Click += pictureBox4_Click;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(0, -1);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(106, 24);
            txtScore.TabIndex = 2;
            txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.obstacle_1;
            pictureBox2.Location = new Point(449, 363);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Black;
            pictureBox5.Location = new Point(-114, 408);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(817, 50);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.obstacle_2;
            pictureBox6.Location = new Point(369, 376);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "obstacle";
            pictureBox6.Click += pictureBox4_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.obstacle_1;
            pictureBox7.Location = new Point(593, 366);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(23, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "obstacle";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Black;
            pictureBox8.Location = new Point(-201, 411);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(817, 50);
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox7);
            Controls.Add(txtScore);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(trex);
            Name = "Form1";
            Text = "T Rex Endless Runner Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox trex;
        private PictureBox pictureBox4;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}