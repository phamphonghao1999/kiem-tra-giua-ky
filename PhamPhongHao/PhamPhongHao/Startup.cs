using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamPhongHao.Startup))]
namespace PhamPhongHao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
