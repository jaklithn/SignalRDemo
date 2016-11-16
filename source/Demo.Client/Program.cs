using System;
using System.Configuration;
using Demo.Client.Extenders;
using Microsoft.AspNet.SignalR.Client;


namespace Demo.Client
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				// Set up connection to hub on server
				var serverUrl = ConfigurationManager.AppSettings["ServerUrl"];
				var hubConnection = new HubConnection(serverUrl);
				var notificationHubProxy = hubConnection.CreateHubProxy("NotificationHub");

                // Register callback methods
                notificationHubProxy.On<string, string, string>("addNotification", (message, header, messageType) =>
                {
                    WriteLine(messageType, $"{header}: {message}");
                });

				// Start connection
				hubConnection.Start().Wait();
				Console.WriteLine("Connected to NotificationHub");

				// Notify hub of client connect
				const string clientName = "Demo.Client";
				notificationHubProxy.Invoke("Notify", clientName, hubConnection.ConnectionId);

				Console.ReadKey();

			}
			catch (Exception ex)
			{
				ColorConsole.WriteLine(ConsoleColor.Red, ex.Message);
				Console.ReadKey();
			}
		}


		#region Support Methods

		private static void WriteLine(string messageType, string message)
		{
			ColorConsole.WriteLine(GetColor(messageType), "{0} {1,-9} {2}", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss.fff"), messageType.ToUpper(), message);
		}

		private static ConsoleColor GetColor(string messageType)
		{
			switch (messageType.ToLowerInvariant())
			{
				case "info":
					return ConsoleColor.Cyan;
				case "success":
					return ConsoleColor.Green;
				case "warning":
					return ConsoleColor.Yellow;
				case "error":
					return ConsoleColor.Red;
				default:
					return ConsoleColor.White;
			}
		}

		#endregion
	}
}