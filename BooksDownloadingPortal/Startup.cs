using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksDownloadingPortal.Startup))]
namespace BooksDownloadingPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
