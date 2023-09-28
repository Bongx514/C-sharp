namespace MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPlayer = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPause = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(89, 262);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(300, 23);
            this.tbPlayer.TabIndex = 0;
            this.tbPlayer.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbPlayer.Value = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.tbPlayer);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(37, 50);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(478, 295);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Now Playing: ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(136, 45);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(206, 186);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BorderColor = System.Drawing.Color.DimGray;
            this.btnPrevious.BorderThickness = 1;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPrevious.Location = new System.Drawing.Point(176, 376);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrevious.Size = new System.Drawing.Size(45, 45);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Tile = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.DimGray;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(334, 376);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.Tile = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(511, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BorderColor = System.Drawing.Color.DimGray;
            this.btnPlay.BorderThickness = 1;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageSize = new System.Drawing.Size(100, 100);
            this.btnPlay.Location = new System.Drawing.Point(235, 354);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.Size = new System.Drawing.Size(83, 86);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Tile = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BorderColor = System.Drawing.Color.DimGray;
            this.btnPause.BorderThickness = 1;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageSize = new System.Drawing.Size(100, 100);
            this.btnPause.Location = new System.Drawing.Point(235, 354);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPause.Size = new System.Drawing.Size(83, 86);
            this.btnPause.TabIndex = 6;
            this.btnPause.Tile = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(22, 8);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(79, 20);
            this.guna2TrackBar1.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.guna2TrackBar1.TabIndex = 3;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2TrackBar1.Value = 1;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.guna2TrackBar1);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(400, 385);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 3;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(115, 36);
            this.guna2ShadowPanel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 451);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar tbPlayer;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrevious;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlay;
        private Guna.UI2.WinForms.Guna2CircleButton btnPause;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
    }
}

