namespace HorseRacing_Rishab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHorse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.horseNo1 = new System.Windows.Forms.PictureBox();
            this.HorseNo3 = new System.Windows.Forms.PictureBox();
            this.HorseNo2 = new System.Windows.Forms.PictureBox();
            this.HorseNo4 = new System.Windows.Forms.PictureBox();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseNo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Winning Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Final Bet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ready";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Items.AddRange(new object[] {
            "Rishab Budget is 100",
            "Sohan Budget is 190",
            "Mohan Budget is 210"});
            this.cbPlayer.Location = new System.Drawing.Point(276, 433);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bet On Horse No";
            // 
            // cbHorse
            // 
            this.cbHorse.FormattingEnabled = true;
            this.cbHorse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbHorse.Location = new System.Drawing.Point(276, 467);
            this.cbHorse.Name = "cbHorse";
            this.cbHorse.Size = new System.Drawing.Size(121, 21);
            this.cbHorse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount to Bet";
            // 
            // horseNo1
            // 
            this.horseNo1.Image = global::HorseRacing_Rishab.Properties.Resources.h1;
            this.horseNo1.Location = new System.Drawing.Point(0, 52);
            this.horseNo1.Name = "horseNo1";
            this.horseNo1.Size = new System.Drawing.Size(92, 50);
            this.horseNo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horseNo1.TabIndex = 10;
            this.horseNo1.TabStop = false;
            // 
            // HorseNo3
            // 
            this.HorseNo3.Image = global::HorseRacing_Rishab.Properties.Resources.h3;
            this.HorseNo3.Location = new System.Drawing.Point(223, 52);
            this.HorseNo3.Name = "HorseNo3";
            this.HorseNo3.Size = new System.Drawing.Size(92, 50);
            this.HorseNo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseNo3.TabIndex = 11;
            this.HorseNo3.TabStop = false;
            // 
            // HorseNo2
            // 
            this.HorseNo2.Image = global::HorseRacing_Rishab.Properties.Resources.h2;
            this.HorseNo2.Location = new System.Drawing.Point(111, 52);
            this.HorseNo2.Name = "HorseNo2";
            this.HorseNo2.Size = new System.Drawing.Size(92, 50);
            this.HorseNo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseNo2.TabIndex = 12;
            this.HorseNo2.TabStop = false;
            // 
            // HorseNo4
            // 
            this.HorseNo4.Image = global::HorseRacing_Rishab.Properties.Resources.h4;
            this.HorseNo4.Location = new System.Drawing.Point(327, 52);
            this.HorseNo4.Name = "HorseNo4";
            this.HorseNo4.Size = new System.Drawing.Size(76, 50);
            this.HorseNo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseNo4.TabIndex = 13;
            this.HorseNo4.TabStop = false;
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(277, 504);
            this.betAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(120, 20);
            this.betAmount.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 551);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.HorseNo4);
            this.Controls.Add(this.HorseNo2);
            this.Controls.Add(this.HorseNo3);
            this.Controls.Add(this.horseNo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHorse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseNo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHorse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox horseNo1;
        private System.Windows.Forms.PictureBox HorseNo3;
        private System.Windows.Forms.PictureBox HorseNo2;
        private System.Windows.Forms.PictureBox HorseNo4;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Timer timer1;
    }
}

