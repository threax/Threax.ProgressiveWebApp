using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.ProgressiveWebApp
{
    public class WebManifestProvider : IWebManifestProvider
    {
        private DisplayConfig displayConfig;
        private IUrlHelper urlHelper;

        public WebManifestProvider(DisplayConfig displayConfig, IUrlHelper urlHelper)
        {
            this.displayConfig = displayConfig;
            this.urlHelper = urlHelper;
        }

        public WebManifest CreateManifest()
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
