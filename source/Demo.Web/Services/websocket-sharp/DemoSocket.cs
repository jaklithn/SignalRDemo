using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Demo.Web.Extenders;
using Demo.Web.Models;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Demo.Web.Services
{
    public class DemoSocket : WebSocketBehavior
    {

        #region Event Handlers

        protected override void OnOpen()
        {
            Debug.WriteLine($"DEBUG DemoSocket opened for '{ID}'");
        }

        protected override void OnClose(CloseEventArgs e)
        {
            Debug.WriteLine($"DEBUG DemoSocket closed for '{ID}'");
        }

        protected override void OnError(ErrorEventArgs e)
        {
            Debug.WriteLine($"ERROR DemoSocket error for '{ID}': {e.Message}");
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if(e.IsPing)
            {
                Debug.WriteLine($"DEBUG DemoSocket Ping from '{ID}'");
            }
            if(e.IsBinary)
            {
                Debug.WriteLine($"DEBUG DemoSocket Binary data ({e.RawData?.Length ?? 0} bytes) from '{ID}'");
            }
            if(e.IsText)
            {
                Debug.WriteLine($"DEBUG DemoSocket Text message from '{ID}'");
                if(e.Data.IsSpecified())
                {
                    // We assume custom EventMessage type as wrapper
                    var eventMessage = JsonConvert.DeserializeObject<EventMessage>(e.Data);

                    // Interpret each message type
                    switch(eventMessage.Type)
                    {
                        case "DummyNotification":
                            Debug.WriteLine($"DEBUG DemoSocket Sending DummyNotifications to '{ID}'");
                            SendDummyNotification(0);
                            SendDummyNotification(1);
                            SendDummyNotification(2);
                            SendDummyNotification(3);
                            break;

                        default:
                            Debug.WriteLine($"WARN DemoSocket EventMessage with type {eventMessage.Type} was not handled");
                            break;
                    }
                }
            }
        }

        #endregion


        #region Public methods

        public static void SendNotification(string connectionId, Notification notification)
        {
            var eventMessage = new EventMessage("Notification", notification);
            var json = JsonConvert.SerializeObject(eventMessage);
            var socket = SocketServerHost.GetInstance().GetSocket<DemoSocket>();
            socket.Sessions.SendTo(json, connectionId);
            //socket.Sessions.Broadcast(json);
        }

        #endregion


        #region Support methods

        private void SendDummyNotification(int notificationId)
        {
            var notifications = new List<Notification>
            {
                new Notification(MessageType.Error, "Error", "This is a demo error message. It will stay until manually closed."),
                new Notification(MessageType.Warning, "Warning", "This is a demo warning message.<br/>A message is manually closed by clicking the x button (or anywhere on the message)."),
                new Notification(MessageType.Success, "Success", "This is a demo success message. It will automatically disappear in 10 s, unless you make it permanent by hovering over it."),
                new Notification(MessageType.Info, "Information", "This is a demo information message. It will automatically disappear in 20 s, unless you make it permanent by hovering over it."),
            };

            SendNotification(ID, notifications[notificationId]);
            Thread.Sleep(2000);
        }

        #endregion
    }
}