using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myNotesApp.Startup))]
namespace myNotesApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
