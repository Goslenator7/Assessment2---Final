using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assessment2___Final.Startup))]
namespace Assessment2___Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
