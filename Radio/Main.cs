using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Radio
{
    public partial class Main : Form
    {
        Station[] stations;
        Player player;
        Genre[] genres;

        public Main()
        {
            InitializeComponent();
            player = new Player();
            genres = API.getGenres();
            if (genres == null)
            {
                MessageBox.Show("An error occurred while fetching genre data");
                Close();
            }
            foreach (Genre g in genres)
                if (g != null && g.name != null)
                    genreSelect.Items.Add(g.name);
            filterOption.SelectedIndex = 0;
            updateSelection();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            stationList.Items.Clear();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string type = "", method = "";
            bool additional = additionalEnable.Checked;
            switch (filterOption.SelectedIndex)
            {
                case 0: // Top 500
                    type = "legacy";
                    method = "Top500";
                    break;
                case 1: // Random
                    type = "station";
                    method = "randomstations";
                    if (additional) parameters.Add("genre", genres[genreSelect.SelectedIndex].name);
                    break;
                case 2: // Genre
                    type = "station";
                    method = "advancedsearch";
                    parameters.Add("genre_id", genres[genreSelect.SelectedIndex].id);
                    break;
                case 3: // Keyword
                    type = "legacy";
                    method = "stationsearch";
                    parameters.Add("search", text.Text.Replace(" ", "+"));
                    break;
                case 4: // Now Playing
                    type = "station";
                    method = "nowplaying";
                    parameters.Add("ct", text.Text.Replace(" ", "+"));
                    break;
            }
            stations = API.getStations(type, method, parameters);
            if (stations != null) foreach (Station s in stations) stationList.Items.Add(s.name);
        }

        private void filterOption_SelectedIndexChanged(object sender, EventArgs e) { updateSelection(); }

        private void updateSelection()
        {
            switch(filterOption.SelectedIndex)
            {
                case 0: // Top 500
                    text.Hide();
                    genreSelect.Hide();
                    additionalEnable.Hide();
                    break;
                case 1: // Random
                    text.Hide();
                    genreSelect.Show();
                    additionalEnable.Show();
                    genreSelect.SelectedIndex = 0;
                    break;
                case 2: // Genre
                    text.Hide();
                    genreSelect.Show();
                    additionalEnable.Hide();
                    additionalEnable.Checked = true;
                    genreSelect.SelectedIndex = 0;
                    break;
                case 3: // Keyword
                case 4: // Now Playing
                    additionalEnable.Hide();
                    additionalEnable.Checked = true;
                    text.Show();
                    genreSelect.Hide();
                    break;
            }
            updateEnabled(additionalEnable.Checked);
        }

        private void updateEnabled(bool addEn)
        {
            text.Enabled = addEn;
            genreSelect.Enabled = addEn;
        }

        private void select(object sender, MouseEventArgs e)
        {
            int index = stationList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches) player.set(stations[index]);
        }

        private void additionalEnable_CheckedChanged(object sender, EventArgs e) { updateEnabled(additionalEnable.Enabled); }
    }
}
