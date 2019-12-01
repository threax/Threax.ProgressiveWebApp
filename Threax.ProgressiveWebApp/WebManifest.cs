using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Threax.ProgressiveWebApp
{
    public class WebManifest
    {
        public string name { get; set; }
        public string short_name { get; set; }
        public string description { get; set; }
        public Icon[] icons { get; set; }
        public string start_url { get; set; }
        public string display { get; set; }
        public string theme_color { get; set; }
        public string background_color { get; set; }
    }
}
