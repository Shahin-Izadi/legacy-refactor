using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LegacyWebForms.Startup))]

namespace LegacyWebForms
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Required for WebApplicationFactory to start the app
        }
    }
}