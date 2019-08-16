using Microsoft.Owin;
using Owin;
using SocialGoal.Web.Helpers;

[assembly: OwinStartupAttribute(typeof(SocialGoal.Startup))]
namespace SocialGoal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var iterator = new Iterator();
            iterator.Execute(10);
            ConfigureAuth(app);
        }
    }
}
