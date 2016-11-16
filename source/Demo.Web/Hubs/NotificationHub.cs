using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Demo.Web.Models;
using Demo.Web.Services;
using Microsoft.AspNet.SignalR;


namespace Demo.Web.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendChatMessage(string message)
        {
            var name = Context.User.Identity.IsAuthenticated ? Context.User.Identity.Name : "Anonymous";
            await Clients.All.addChatMessage(name, message);
        }

        public void SendNotification(string message, string header, string messageType)
        {
            Clients.All.addNotification(message, header, messageType);
        }

        [Authorize]
        public async Task SetSubscription(int machineId, bool isSubscribed)
        {
            var userId = Context.User.Identity.Name;
            await Task.Run(() => SubscriptionService.SetSubscription(userId, machineId, isSubscribed));
        }

        [Authorize(Roles = "Admin")]
        public void SendActionToSubscribers(int machineId, string action)
        {
            var userIds = SubscriptionService.GetSubscribedUsers(machineId);
            var machine = new MachineRepository().GetMachine(machineId);

            switch (action)
            {
                case "online":
                    Clients.Users(userIds).addNotification($"{machine.Name} is now online", "Online", "info");
                    break;
                case "screenDumpReady":
                    var screenDumpUrl = MachineRepository.GetUrlForGeneratedPicture(machineId);
                    Clients.Users(userIds).addNotification($"{machine.Name} screen dump is now ready", "Screen Dump", "success");
                    Clients.Users(userIds).addScreenDumpNotification(machineId, screenDumpUrl, $"ScreenDump created {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    break;
            }
        }

        public async Task SendLunch(string meat, string fish, string vegetarian, string meatPrice, string fishPrice, string vegetarianPrice)
        {
            await Clients.All.displayLunch(meat, fish, vegetarian, meatPrice, fishPrice, vegetarianPrice);
        }

        public void Notify(string clientName, Guid connectionId)
        {
            Debug.WriteLine($"DEBUG: Client '{clientName}' with ConnectionId={connectionId} was connected");
        }


        #region Event Handler Overrides

        //public override Task OnConnected()
        //{
        //	Debug.WriteLine($"DEBUG Connected: {Context.ConnectionId}");
        //	return base.OnConnected();
        //}

        //public override Task OnReconnected()
        //{
        //	Debug.WriteLine($"DEBUG Reconnected: {Context.ConnectionId}");
        //	return base.OnReconnected();
        //}

        //public override Task OnDisconnected(bool stopCalled)
        //{
        //	Debug.WriteLine($"DEBUG Disconnected: {Context.ConnectionId}");
        //	return base.OnDisconnected(stopCalled);
        //}

        #endregion


        #region Further examples

        /// <summary>
        /// Asynchronous signatures are preferred for long running calls, to not block the connection.
        /// SignalR will automatically handle the difference in communication.
        /// The client signature will be identical as long as the method name is identical.
        /// </summary>
        public async Task SendToAllAsync(string message)
        {
            await Clients.All.addNotification(message);
        }

        /// <summary>
        /// Progress feedback is possible.
        /// These calls are typically longrunning and should therefore always be asynchronous!
        /// IProgress takes a generic type: int, string or custom complex type.
        /// </summary>
        public async Task<string> DoLongRunningThing(IProgress<ProgressItem> progress)
        {
            for (var i = 0; i <= 100; i += 5)
            {
                await Task.Delay(200);
                if (i < 30)
                {
                    progress.Report(new ProgressItem { Message = $"Processing the FIRST part ({i}%)", Percent = i });
                }
                else if (i < 60)
                {
                    progress.Report(new ProgressItem { Message = $"Processing the SECOND part ({i}%)", Percent = i });
                }
                else
                {
                    progress.Report(new ProgressItem { Message = $"Processing the THIRD part ({i}%)", Percent = i });
                }
            }

            return "Job is complete";
        }

        public async Task SendSensorValue(string key, decimal value)
        {
            await Clients.All.setSensorValue(key, value);
        }


        public async Task SendMapPosition(string key, double latitude, double longitude, int boxCount)
        {
            await Clients.All.setMapPosition(key, latitude, longitude, boxCount);
        }

        #endregion
    }
}