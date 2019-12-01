using Microsoft.AspNetCore.Mvc;

namespace Threax.ProgressiveWebApp
{
    public interface IWebManifestProvider
    {
        WebManifest CreateManifest(IUrlHelper urlHelper);
    }
}