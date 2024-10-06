namespace TicTacGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pos9 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos8 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos7 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos6 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos5 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos4 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos3 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos2 = new Guna.UI2.WinForms.Guna2Button();
            this.Pos1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Pos9);
            this.guna2Panel1.Controls.Add(this.Pos8);
            this.guna2Panel1.Controls.Add(this.Pos7);
            this.guna2Panel1.Controls.Add(this.Pos6);
            this.guna2Panel1.Controls.Add(this.Pos5);
            this.guna2Panel1.Controls.Add(this.Pos4);
            this.guna2Panel1.Controls.Add(this.Pos3);
            this.guna2Panel1.Controls.Add(this.Pos2);
            this.guna2Panel1.Controls.Add(this.Pos1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(362, 529);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 467);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(337, 51);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Restart The Game";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(172, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TicTacGame.Properties.Resources.close__1_;
            this.pictureBox2.Location = new System.Drawing.Point(79, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TicTacGame.Properties.Resources.letter_o;
            this.pictureBox1.Location = new System.Drawing.Point(309, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player1";
            // 
            // Pos9
            // 
            this.Pos9.BackColor = System.Drawing.Color.Transparent;
            this.Pos9.BorderColor = System.Drawing.Color.Crimson;
            this.Pos9.BorderRadius = 5;
            this.Pos9.BorderThickness = 2;
            this.Pos9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos9.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos9.ForeColor = System.Drawing.Color.White;
            this.Pos9.Location = new System.Drawing.Point(242, 370);
            this.Pos9.Name = "Pos9";
            this.Pos9.Size = new System.Drawing.Size(107, 85);
            this.Pos9.TabIndex = 11;
            this.Pos9.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos8
            // 
            this.Pos8.BackColor = System.Drawing.Color.Transparent;
            this.Pos8.BorderColor = System.Drawing.Color.Crimson;
            this.Pos8.BorderRadius = 5;
            this.Pos8.BorderThickness = 2;
            this.Pos8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos8.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos8.ForeColor = System.Drawing.Color.White;
            this.Pos8.Location = new System.Drawing.Point(126, 370);
            this.Pos8.Name = "Pos8";
            this.Pos8.Size = new System.Drawing.Size(107, 85);
            this.Pos8.TabIndex = 10;
            this.Pos8.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos7
            // 
            this.Pos7.BackColor = System.Drawing.Color.Transparent;
            this.Pos7.BorderColor = System.Drawing.Color.Crimson;
            this.Pos7.BorderRadius = 5;
            this.Pos7.BorderThickness = 2;
            this.Pos7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos7.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos7.ForeColor = System.Drawing.Color.White;
            this.Pos7.Location = new System.Drawing.Point(11, 370);
            this.Pos7.Name = "Pos7";
            this.Pos7.Size = new System.Drawing.Size(107, 85);
            this.Pos7.TabIndex = 9;
            this.Pos7.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos6
            // 
            this.Pos6.BackColor = System.Drawing.Color.Transparent;
            this.Pos6.BorderColor = System.Drawing.Color.Crimson;
            this.Pos6.BorderRadius = 5;
            this.Pos6.BorderThickness = 2;
            this.Pos6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos6.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos6.ForeColor = System.Drawing.Color.White;
            this.Pos6.Location = new System.Drawing.Point(242, 279);
            this.Pos6.Name = "Pos6";
            this.Pos6.Size = new System.Drawing.Size(107, 85);
            this.Pos6.TabIndex = 8;
            this.Pos6.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos5
            // 
            this.Pos5.BackColor = System.Drawing.Color.Transparent;
            this.Pos5.BorderColor = System.Drawing.Color.Crimson;
            this.Pos5.BorderRadius = 5;
            this.Pos5.BorderThickness = 2;
            this.Pos5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos5.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos5.ForeColor = System.Drawing.Color.White;
            this.Pos5.Location = new System.Drawing.Point(126, 279);
            this.Pos5.Name = "Pos5";
            this.Pos5.Size = new System.Drawing.Size(107, 85);
            this.Pos5.TabIndex = 7;
            this.Pos5.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos4
            // 
            this.Pos4.BackColor = System.Drawing.Color.Transparent;
            this.Pos4.BorderColor = System.Drawing.Color.Crimson;
            this.Pos4.BorderRadius = 5;
            this.Pos4.BorderThickness = 2;
            this.Pos4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos4.ForeColor = System.Drawing.Color.White;
            this.Pos4.Location = new System.Drawing.Point(11, 279);
            this.Pos4.Name = "Pos4";
            this.Pos4.Size = new System.Drawing.Size(107, 85);
            this.Pos4.TabIndex = 6;
            this.Pos4.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos3
            // 
            this.Pos3.BackColor = System.Drawing.Color.Transparent;
            this.Pos3.BorderColor = System.Drawing.Color.Crimson;
            this.Pos3.BorderRadius = 5;
            this.Pos3.BorderThickness = 2;
            this.Pos3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos3.ForeColor = System.Drawing.Color.White;
            this.Pos3.Location = new System.Drawing.Point(242, 188);
            this.Pos3.Name = "Pos3";
            this.Pos3.Size = new System.Drawing.Size(107, 85);
            this.Pos3.TabIndex = 5;
            this.Pos3.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos2
            // 
            this.Pos2.BackColor = System.Drawing.Color.Transparent;
            this.Pos2.BorderColor = System.Drawing.Color.Crimson;
            this.Pos2.BorderRadius = 5;
            this.Pos2.BorderThickness = 2;
            this.Pos2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos2.ForeColor = System.Drawing.Color.White;
            this.Pos2.Location = new System.Drawing.Point(126, 188);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(107, 85);
            this.Pos2.TabIndex = 4;
            this.Pos2.Click += new System.EventHandler(this.Click_Position);
            // 
            // Pos1
            // 
            this.Pos1.BackColor = System.Drawing.Color.Transparent;
            this.Pos1.BorderColor = System.Drawing.Color.Crimson;
            this.Pos1.BorderRadius = 5;
            this.Pos1.BorderThickness = 2;
            this.Pos1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pos1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pos1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pos1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pos1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Pos1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pos1.ForeColor = System.Drawing.Color.White;
            this.Pos1.Location = new System.Drawing.Point(11, 188);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(107, 85);
            this.Pos1.TabIndex = 3;
            this.Pos1.Click += new System.EventHandler(this.Click_Position);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(80, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tic";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(145, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tac";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 529);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicTac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button Pos9;
        private Guna.UI2.WinForms.Guna2Button Pos8;
        private Guna.UI2.WinForms.Guna2Button Pos7;
        private Guna.UI2.WinForms.Guna2Button Pos6;
        private Guna.UI2.WinForms.Guna2Button Pos5;
        private Guna.UI2.WinForms.Guna2Button Pos4;
        private Guna.UI2.WinForms.Guna2Button Pos3;
        private Guna.UI2.WinForms.Guna2Button Pos2;
        private Guna.UI2.WinForms.Guna2Button Pos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

