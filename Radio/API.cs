using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Radio
{
    static class API
    {
        private const string baseURL = "http://api.shoutcast.com/";
        private const string devID = "1P2jWgrfHgLEosPC";
        public static WebClient client = new WebClient();

        public static Station[] getStations(string type, string method, Dictionary<string, string> parameters)
        {
            XmlNode list = get(type, method, parameters);
            if (list != null)
            {
                Station[] stations = new Station[list.ChildNodes.Count - 1];
                for (int i = 1; i < list.ChildNodes.Count; ++i)
                {
                    XmlAttributeCollection attributes = list.ChildNodes[i].Attributes;
                    XmlNode ctattrib = attributes.GetNamedItem("ct");
                    string ct = "";
                    if (ctattrib != null) ct = ctattrib.InnerText;
                    stations[i - 1] = new Station(
                        attributes.GetNamedItem("name").InnerText,
                        attributes.GetNamedItem("mt").InnerText,
                        attributes.GetNamedItem("genre").InnerText,
                        attributes.GetNamedItem("id").InnerText,
                        attributes.GetNamedItem("br").InnerText,
                        attributes.GetNamedItem("lc").InnerText,
                        ct
                    );
                }
                return stations;
            }
            return new Station[] { };
        }

        public static Genre[] getGenres()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            XmlNode list = get("genre", "primary", null);
            if(list != null)
            {
                Genre[] genres = new Genre[list.ChildNodes.Count];
                for (int i = 0; i < list.ChildNodes.Count; ++i)
                {
                    XmlAttributeCollection attributes = list.ChildNodes[i].Attributes;
                    genres[i] = new Genre(
                        attributes.GetNamedItem("name").InnerText,
                        attributes.GetNamedItem("id").InnerText
                    );
                }
                return genres;
            }
            return new Genre[] { };
        }

        private static XmlNode get(string type, string method, Dictionary<string, string> parameters)
        {
            string urlParams = "";
            if(parameters != null) foreach (KeyValuePair<string, string> p in parameters) urlParams += "&" + Uri.EscapeUriString(p.Key) + "=" + Uri.EscapeUriString(p.Value);
            string response = client.DownloadString(baseURL + type + "/" + method + "?k=" + devID + "&f=xml&" + urlParams).Trim();
            XmlDocument doc = new XmlDocument();
            if(response == "")
            {
                MessageBox.Show("An error occurred while calling the API: Response is blank");
                return null;
            }
            doc.LoadXml(response);
            XmlNode list = doc.ChildNodes[1];
            // Checking for errors
            if ((type == "legacy" && doc.Name == "response") || (type != "legacy" && list["statusCode"].Name == "200"))
            {
                MessageBox.Show("An error occurred while calling the API\n" + doc["statusText"] + ": " + doc["statusDetailText"]);
                return null;
            }
            if (type != "legacy") list = list["data"][type == "genre" ? "genrelist" : "stationlist"];
            return list;
        }
    }
}
