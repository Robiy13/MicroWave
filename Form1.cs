using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Data.OleDb;

namespace MicroWave_Player
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;

        public Form1()
        {
            InitializeComponent();
            volume.Value = 50;
            trackvolume.Text = "50%";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string[] paths, files;
        private object system;

        private void tracklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[tracklist.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[tracklist.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox2.Image = Image.FromStream(new MemoryStream(bin));
            }

            catch 
            {
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            player.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnForeward_Click(object sender, EventArgs e)
        {
            if (tracklist.SelectedIndex < tracklist.Items.Count - 1) { 
            
                tracklist.SelectedIndex = tracklist.SelectedIndex+ 1;
            
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
                if (tracklist.SelectedIndex > 0) 
                {

                    tracklist.SelectedIndex = tracklist.SelectedIndex - 1;

                }
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
            trackvolume.Text = volume.Value.ToString() + "%";
        }

        private void pBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                pBar.Value=(int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;

            }
            catch 
            { 
            
            }
        }

        private void trackvolume_Click(object sender, EventArgs e)
        {

        }

        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pBar.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y; 
        }

        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    tracklist.Items.Add(files[x]);
                }
            }
        }
    }
}
