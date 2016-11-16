using Demo.Web;
using Demo.Web.Services;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(Startup))]

namespace Demo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // If SignalR is used we start it here
            app.MapSignalR();

            // If websocket-sharp is used we make sure the singleton instance is started
            // SocketServerHost.GetInstance();
        }
    }
}