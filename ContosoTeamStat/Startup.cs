using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoTeamStat.Startup))]
namespace ContosoTeamStat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
