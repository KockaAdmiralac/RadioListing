using System;
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
        }

        public void set(string source, string name, int volume)
        {
            player.URL = source;
            currentlyPlaying.Text = name;
            player.settings.volume = volume;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playText.Show();
            currentlyPlaying.Show();
            player.controls.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            playText.Hide();
            currentlyPlaying.Hide();
            player.controls.pause();
        }
    }
}
