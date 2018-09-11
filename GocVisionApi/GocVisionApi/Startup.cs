using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GocVisionApi.Startup))]
namespace GocVisionApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
