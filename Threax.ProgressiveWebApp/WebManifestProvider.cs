using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.ProgressiveWebApp
{
    public class WebManifestProvider : IWebManifestProvider
    {
        private DisplayConfig displayConfig;

        public WebManifestProvider(DisplayConfig displayConfig)
        {
            this.displayConfig = displayConfig;
        }

        public WebManifest CreateManifest(IUrlHelper urlHelper)
        {
            return new WebManifest()
            {
                name = displayConfig.SiteName,
                short_name = displayConfig.SiteNameShort,
                description = displayConfig.Description,
                background_color = displayConfig.BackgroundColor,
                display = displayConfig.Display,
                start_url = urlHelper.Content(displayConfig.StartUrl),
                theme_color = displayConfig.ThemeColor,
                icons = new Icon[]
                {
                    new Icon()
                    {
                        src = urlHelper.Content(displayConfig.Icon.src),
                        sizes = displayConfig.Icon.sizes,
                        type = displayConfig.Icon.type
                    }
                }
            };
        }
    }
}
