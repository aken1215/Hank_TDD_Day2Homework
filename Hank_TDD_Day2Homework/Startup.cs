using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hank_TDD_Day2Homework.Startup))]
namespace Hank_TDD_Day2Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
