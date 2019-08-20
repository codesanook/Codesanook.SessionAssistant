using Orchard.UI.Resources;

namespace Codesanook.SessionAssistant
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("SignalR").SetUrl("~/signalr/hubs");
        }
    }
}
