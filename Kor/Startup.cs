using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kor.Startup))]
namespace Kor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
