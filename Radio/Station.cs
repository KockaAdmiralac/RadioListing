using System.Collections.Generic;

namespace Radio
{
    public class Station
    {
        public string name, mediaType, genre, id, bitrate, lc, currentlyPlaying;
        List<string> streamURLs;
        public Station(string name, string mediaType, string genre, string id, string bitrate, string lc, string currentlyPlaying)
        {
            this.name = name;
            this.mediaType = mediaType;
            this.genre = genre;
            this.id = id;
            this.bitrate = bitrate;
            this.lc = lc;
            this.currentlyPlaying = currentlyPlaying;
        }
        public List<string> fetchStreamURLs()
        {
            if(streamURLs == null)
            {
                streamURLs = new List<string>();
                string[] lines = API.client.DownloadString("http://yp.shoutcast.com/sbin/tunein-station.pls?id=" + id).Trim().Split('\n');
                foreach (string line in lines) if (line.Substring(0, 4) == "File") streamURLs.Add(line.Substring(6));
            }
            return streamURLs;
        }
    }
}
