using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambot_Json
{
    //Add construct to the json key if needed according to json
    internal class JsonObject
    {
        public class ControlButton
        {
            public Dictionary<string, string> buttonText { get; set; }
            public Dictionary<string, string> buttonNav { get; set; }
        }

        public class Contents
        {
            public string logo { get; set; }
            public string image1 { get; set; }
            public string image2 { get; set; }
            public string image3 { get; set; }
            public string image4 { get; set; }
            public string title { get; set; }
            public string title1 { get; set; }
            public string title2 { get; set; }
            public string title3 { get; set; }
            public string title4 { get; set; }
            public string subtitle1 { get; set; }
            public string subtitle2 { get; set; }
            public string subtitle3 { get; set; }
            public string subtitle4 { get; set; }
            public string description1 { get; set; }
            public string description2 { get; set; }
            public string description3 { get; set; }
            public string instruction { get; set; }
        }

        public class Pages
        {
            public string PageNav { get; set; }
            public string PageName { get; set; }
            public ControlButton Button { get; set; }
            public Contents Contents { get; set; }
        }

        public class Root
        {
            public Dictionary<string, Pages> Pages { get; set; }

            public static Root Deserialize()
            {
                // Deserialize the JSON file into a C# object
                string path = Path.Combine(Environment.CurrentDirectory, "Ambot.json");
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<JsonObject.Root>(json);
            }
        }



    }
}
