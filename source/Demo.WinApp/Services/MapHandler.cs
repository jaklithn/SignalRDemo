using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Demo.WinApp.Entities;
using Microsoft.AspNet.SignalR.Client;


namespace Demo.WinApp.Services
{
    public static class MapHandler
    {
        private static IHubProxy _hubProxy;
        private static List<Position> _positions;
        private static Dictionary<string, int> _lastSentOrders;
        private static Timer _timer;

        public static void Start(IHubProxy hubproxy)
        {
            if (_hubProxy == null)
            {
                _hubProxy = hubproxy;
                _positions = new List<Position>();
                _lastSentOrders = new Dictionary<string, int>();
                
                _timer = new Timer() { Interval = 1000 };
                _timer.Tick += Timer_Tick;

                GeneratePositions();
            }
            _timer.Start();
        }

        public static void Pause()
        {
            _timer?.Stop();
        }

        public static void Stop()
        {
            _timer?.Stop();
            _hubProxy = null;
        }

        #region Private Methods

        private static void GeneratePositions()
        {
            AddPosition("car", 5, 57.703632, 11.962519, 3);
            AddPosition("car", 5, 57.703311, 11.962696, 5);
            AddPosition("car", 5, 57.703128, 11.961500, 5);
            AddPosition("car", 4, 57.703667, 11.961243, 5);
            AddPosition("car", 4, 57.705200, 11.960918, 20);
            AddPosition("car", 3, 57.705326, 11.961503, 3);
            AddPosition("car", 2, 57.705445, 11.961678, 2);
            AddPosition("car", 2, 57.705628, 11.962858, 5);
            AddPosition("car", 1, 57.705055, 11.963153, 5);
            AddPosition("car", 1, 57.704009, 11.963706, 10);
            AddPosition("car", 0, 57.703814, 11.962419, 5);

            AddPosition("truck", 9, 57.703632, 11.962519, 3);
            AddPosition("truck", 9, 57.703814, 11.962402, 3);
            AddPosition("truck", 9, 57.704009, 11.963706, 5);
            AddPosition("truck", 8, 57.702843, 11.964397, 10);
            AddPosition("truck", 8, 57.702009, 11.965448, 10);
            AddPosition("truck", 8, 57.702084, 11.965523, 2);
            AddPosition("truck", 7, 57.702903, 11.964528, 8);
            AddPosition("truck", 4, 57.703528, 11.964200, 5);
            AddPosition("truck", 3, 57.703683, 11.965128, 5);
            AddPosition("truck", 2, 57.703935, 11.966748, 5);
            AddPosition("truck", 1, 57.704434, 11.966437, 5);
            AddPosition("truck", 0, 57.703815, 11.962403, 20);

            foreach(var key in _positions.Select(x => x.Key).Distinct())
            {
                _lastSentOrders.Add(key, 0);
            }

            //foreach (var key in _positions.Select(x => x.Key).Distinct())
            //{
            //	foreach (var position in _positions.Where(x => x.Key == key).OrderBy(x => x.Order))
            //	{
            //		Debug.WriteLine($"{position.Key}: {position.Latitude:N6}, {position.Longitude:N6}");
            //	}
            //}
        }

        private static void SendNextPosition()
        {
            foreach(var key in _positions.Select(x => x.Key).Distinct())
            {
                var lastSentOrder = _lastSentOrders[key];
                var maxPosition = _positions.Where(x => x.Key == key).Max(x => x.Order);

                Position position;
                int order;
                if(lastSentOrder == 0 || lastSentOrder == maxPosition)
                {
                    order = 1;
                    position = _positions.Single(x => x.Key == key && x.Order == 1);
                }
                else
                {
                    order = lastSentOrder + 1;
                    position = _positions.Single(x => x.Key == key && x.Order == order);
                }
                SendPosition(position.Key, position.Latitude, position.Longitude, position.BoxCount);
                _lastSentOrders[key] = order;
            }
        }

        private static void AddPosition(string key, int boxCount, double latitude, double longitude, int stepSincePrevious = 1)
        {
            var lastPosition = _positions.Where(x => x.Key == key).OrderBy(x => x.Order).LastOrDefault();
            if(lastPosition == null)
            {
                _positions.Add(new Position {Key = key, Order = 1, Latitude = latitude, Longitude = longitude, BoxCount = boxCount});
            }
            else
            {
                var latStep = (latitude - lastPosition.Latitude) / stepSincePrevious;
                var longStep = (longitude - lastPosition.Longitude) / stepSincePrevious;
                for(var i = 1; i <= stepSincePrevious; i++)
                {
                    var order = lastPosition.Order + i;
                    var latValue = lastPosition.Latitude + i * latStep;
                    var longValue = lastPosition.Longitude + i * longStep;
                    _positions.Add(new Position {Key = key, Order = order, Latitude = latValue, Longitude = longValue, BoxCount = boxCount});
                }
            }
        }

        private static void SendPosition(string key, double latitude, double longitude, int boxCount)
        {
            _hubProxy.Invoke("SendMapPosition", key, latitude, longitude, boxCount);
        }

        #endregion

        #region Event Handlers

        private static void Timer_Tick(object sender, EventArgs e)
        {
            SendNextPosition();
        }

        #endregion

    }
}