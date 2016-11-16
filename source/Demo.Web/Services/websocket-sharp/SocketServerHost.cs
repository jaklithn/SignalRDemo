using WebSocketSharp.Server;

namespace Demo.Web.Services
{
    /// <summary>
    /// Register all needed socket services in this host.
    /// They will currently default to ws://localhost:portnumber/servicename
    /// Example:
    /// Using port 4969 the DemoSocket service will be reached at  ws://localhost:4969/DemoSocket
    /// 
    /// TODO: Don't forget to initiate in Startup.cs if you use this alternative!
    /// </summary>
    public class SocketServerHost
    {
        private static SocketServerHost _socketServerHost;
        private const int Port = 4969; // TODO: Maybe expose as config setting?
        private readonly WebSocketServer _wss;

        public WebSocketServiceHost GetSocket<T>() where T : WebSocketBehavior
        {
            var socketName = GetName<T>();
            return _wss.WebSocketServices[socketName];
        }

        private static string GetName<T>()
        {
            return $"/{typeof(T).Name}";
        }


        #region Constructor

        private SocketServerHost()
        {
            _wss = new WebSocketServer(Port);
            _wss.AddWebSocketService<DemoSocket>(GetName<DemoSocket>());
            _wss.Start();
        }

        public static SocketServerHost GetInstance()
        {
            return _socketServerHost ?? (_socketServerHost = new SocketServerHost());
        }

        #endregion
    }
}