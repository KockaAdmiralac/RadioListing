using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace Radio
{
    public partial class Player : Form
    {
        private WindowsMediaPlayer player;

        public Player()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.settings.volume = volumeBar.Value * 4;
        }

        public void set(Station station)
        {
            List<string> streamURLs = station.fetchStreamURLs();
            if(streamURLs != null && streamURLs.Count == 0)
            {
                MessageBox.Show("Cannot fetch stream URLs!");
                return;
            }
            player.URL = streamURLs[0];
            currentlyPlaying.Text = station.currentlyPlaying;
            Show();
            play();
        }

        private void play()
        {
            playText.Show();
            currentlyPlaying.Show();
            player.controls.play();
        }

        private void pause()
        {
            playText.Hide();
            currentlyPlaying.Hide();
            player.controls.pause();
        }

        private void playButton_Click(object sender, EventArgs e) { play(); }
        private void pauseButton_Click(object sender, EventArgs e) { pause(); }

        private void volumeBar_Scroll(object sender, EventArgs e) { player.settings.volume = volumeBar.Value * 4; }

        private void moveUpperLeft_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
        private void moveLowerRight_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void exit_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
