namespace MicroWave_Player
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
            this.pnlfotter = new System.Windows.Forms.Panel();
            this.trackvolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnForeward = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tracklist = new System.Windows.Forms.ListBox();
            this.picArt = new System.Windows.Forms.PictureBox();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlfotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlfotter
            // 
            this.pnlfotter.BackColor = System.Drawing.Color.DimGray;
            this.pnlfotter.Controls.Add(this.trackvolume);
            this.pnlfotter.Controls.Add(this.label1);
            this.pnlfotter.Controls.Add(this.volume);
            this.pnlfotter.Controls.Add(this.pBar);
            this.pnlfotter.Controls.Add(this.btnRewind);
            this.pnlfotter.Controls.Add(this.btnStop);
            this.pnlfotter.Controls.Add(this.btnForeward);
            this.pnlfotter.Controls.Add(this.btnPlay);
            this.pnlfotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfotter.Location = new System.Drawing.Point(0, 494);
            this.pnlfotter.Name = "pnlfotter";
            this.pnlfotter.Size = new System.Drawing.Size(754, 100);
            this.pnlfotter.TabIndex = 0;
            // 
            // trackvolume
            // 
            this.trackvolume.AutoSize = true;
            this.trackvolume.Location = new System.Drawing.Point(718, 56);
            this.trackvolume.Name = "trackvolume";
            this.trackvolume.Size = new System.Drawing.Size(33, 13);
            this.trackvolume.TabIndex = 8;
            this.trackvolume.Text = "100%";
            this.trackvolume.Click += new System.EventHandler(this.trackvolume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "VOLUME";
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.Location = new System.Drawing.Point(592, 29);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(159, 45);
            this.volume.TabIndex = 6;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.BackColor = System.Drawing.Color.Magenta;
            this.pBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pBar.Location = new System.Drawing.Point(12, 5);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(730, 19);
            this.pBar.TabIndex = 2;
            this.pBar.Click += new System.EventHandler(this.pBar_Click);
            this.pBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // btnRewind
            // 
            this.btnRewind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRewind.BackColor = System.Drawing.Color.DimGray;
            this.btnRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRewind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind.ForeColor = System.Drawing.Color.Black;
            this.btnRewind.Image = ((System.Drawing.Image)(resources.GetObject("btnRewind.Image")));
            this.btnRewind.Location = new System.Drawing.Point(205, 30);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(48, 44);
            this.btnRewind.TabIndex = 5;
            this.btnRewind.UseVisualStyleBackColor = false;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.DimGray;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(362, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 44);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnForeward
            // 
            this.btnForeward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForeward.BackColor = System.Drawing.Color.DimGray;
            this.btnForeward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForeward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForeward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeward.ForeColor = System.Drawing.Color.Black;
            this.btnForeward.Image = ((System.Drawing.Image)(resources.GetObject("btnForeward.Image")));
            this.btnForeward.Location = new System.Drawing.Point(448, 30);
            this.btnForeward.Name = "btnForeward";
            this.btnForeward.Size = new System.Drawing.Size(48, 44);
            this.btnForeward.TabIndex = 3;
            this.btnForeward.UseVisualStyleBackColor = false;
            this.btnForeward.Click += new System.EventHandler(this.btnForeward_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.DimGray;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(278, 30);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 44);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.DimGray;
            this.pnlheader.Controls.Add(this.name);
            this.pnlheader.Controls.Add(this.btnClose);
            this.pnlheader.Controls.Add(this.btnOpen);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(754, 45);
            this.pnlheader.TabIndex = 1;
            this.pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseDown);
            this.pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseMove);
            this.pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseUp);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(273, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 25);
            this.name.TabIndex = 5;
            this.name.Text = "MicroWave Player";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(676, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.DimGray;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(12, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 38);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tracklist
            // 
            this.tracklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tracklist.BackColor = System.Drawing.Color.DimGray;
            this.tracklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracklist.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracklist.ForeColor = System.Drawing.Color.White;
            this.tracklist.FormattingEnabled = true;
            this.tracklist.ItemHeight = 17;
            this.tracklist.Location = new System.Drawing.Point(141, 119);
            this.tracklist.Name = "tracklist";
            this.tracklist.Size = new System.Drawing.Size(603, 357);
            this.tracklist.TabIndex = 3;
            this.tracklist.SelectedIndexChanged += new System.EventHandler(this.tracklist_SelectedIndexChanged);
            // 
            // picArt
            // 
            this.picArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picArt.Image = ((System.Drawing.Image)(resources.GetObject("picArt.Image")));
            this.picArt.Location = new System.Drawing.Point(5, 120);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(133, 130);
            this.picArt.TabIndex = 3;
            this.picArt.TabStop = false;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.DimGray;
            this.lbl_track_start.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.Location = new System.Drawing.Point(55, 267);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(88, 37);
            this.lbl_track_start.TabIndex = 5;
            this.lbl_track_start.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"WAV (*.wav)|*.wav";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 130);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 45);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(754, 52);
            this.player.TabIndex = 4;
            this.player.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(754, 594);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tracklist);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picArt);
            this.Controls.Add(this.pnlheader);
            this.Controls.Add(this.pnlfotter);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlfotter.ResumeLayout(false);
            this.pnlfotter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlfotter;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnForeward;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListBox tracklist;
        private System.Windows.Forms.PictureBox picArt;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label trackvolume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

