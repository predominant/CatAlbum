using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cat_Album.Startup))]
namespace Cat_Album
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
