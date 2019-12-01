using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Threax.ProgressiveWebApp
{
    public class DisplayConfig
    {
        private String description = null;
        private String siteNameShort = null;

        /// <summary>
        /// The name of the site. Will be reflected in various places.
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// The name of the site in a short form. Defaults to the normal site name.
        /// </summary>
        public string SiteNameShort
        {
            get
            {
                return siteNameShort ?? SiteName;
            }
            set
            {
                siteNameShort = value;
            }
        }

        /// <summary>
        /// The name of the favicon. Will be served as the favicon.
        /// </summary>
        public string Favicon { get; set; } = "~/icons/favicon.ico";

        /// <summary>
        /// The description for the app. Defaults to the SiteName.
        /// </summary>
        public String Description
        {
            get
            {
                return description ?? SiteName;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>
        /// The name of the icon. Will be used in the manifest.
        /// </summary>
        public Icon Icon { get; set; } = new Icon()
        {
            src = "~/icons/icon.png",
            sizes = "512x512"
        };

        public string StartUrl { get; set; } = "~/AppStart";
        public string Display { get; set; } = "standalone";
        public string ThemeColor { get; set; } = "#222222";
        public string BackgroundColor { get; set; } = "#222222";
    }
}
