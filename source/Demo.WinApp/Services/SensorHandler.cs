using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace Demo.WinApp.Services
{
    public static class SensorHandler
    {
        private static IHubProxy _hubProxy;
        public static Dictionary<string, double> PreviousValues;
        private static Random _randomizer;
        private static Timer _timer;

        public static void Start(IHubProxy hubproxy)
        {
            if(_hubProxy == null)
            {
                _hubProxy = hubproxy;
                _randomizer = new Random(DateTime.Now.Second);
                PreviousValues = new Dictionary<string, double>();
                _timer = new Timer() {Interval = 500};
                _timer.Tick += Timer_Tick;
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

        private static void SendValue(string key, double value)
        {
            _hubProxy.Invoke("SendSensorValue", key, value);
        }

        private static double GetValue(string key, double min, double max, double start, double maxChange)
        {
            var previousValue = PreviousValues.ContainsKey(key) ? PreviousValues[key] : start;
            var value = previousValue + _randomizer.NextDouble() * maxChange;
            value = Math.Min(value, max);
            value = Math.Max(value, min);
            return value;
        }

        #endregion

        #region Event Handlers

        private static void Timer_Tick(object sender, EventArgs e)
        {
            SendValue("memory", GetValue("memory", 0, 16, 4, 2));
            SendValue("cpu", GetValue("cpu", 0, 100, 40, 20));
            SendValue("network", GetValue("network", 0, 300, 200, 40));
            SendValue("temp", GetValue("temp", -20, 50, 20, 5));
        }

        #endregion
    }
}