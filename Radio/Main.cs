using System;
using System.Windows.Forms;

namespace Radio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Paradajz.player = new Player();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paradajz.player.set("http://wms-15.streamsrus.com:15710", "Random station", 100);
            Paradajz.player.Show();
        }
    }
}
