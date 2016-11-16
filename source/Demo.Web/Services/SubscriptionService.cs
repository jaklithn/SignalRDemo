using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Demo.Web.Models;
using Newtonsoft.Json;

namespace Demo.Web.Services
{
    /// <summary>
    /// Very simple memory storage of subscriptions.
    /// Currently stored as file to disk between executions.
    /// In production scenarios you will probably save data in persistant storage like SQL Server or Redis.
    /// </summary>
    public static class SubscriptionService
    {
        private static readonly string SubscriptionFileName = Path.GetTempPath() + "Subscriptions.json";
        private static ConcurrentDictionary<int, SubscribedMachine> _machines;
        private static readonly object ThisLock = new object();

        static SubscriptionService()
        {
            ReadFromFile();
        }

        public static void SetSubscription(string userId, int machineId, bool isSubscribed)
        {
            SubscribedMachine machine;
            _machines.TryGetValue(machineId, out machine);
            if (machine == null)
            {
                machine = new SubscribedMachine(machineId);
                _machines.TryAdd(machineId, machine);
            }
            if (isSubscribed)
            {
                machine.UserIds.TryAdd(userId, DateTime.Now);
            }
            else
            {
                DateTime dummy;
                machine.UserIds.TryRemove(userId, out dummy);
            }
            SaveToFile();
        }

        /// <summary>
        /// The most frequent called method should be fast.
        /// </summary>
        public static string[] GetSubscribedUsers(int machineId)
        {
            SubscribedMachine machine;
            _machines.TryGetValue(machineId, out machine);
            if (machine != null)
            {
                return machine.UserIds.Keys.ToArray();
            }

            return new string[] { };
        }

        /// <summary>
        /// This method is slightly slower, but is not called that often.
        /// </summary>
        public static int[] GetSubscribedMachines(string userId)
        {
            var machineIds = new HashSet<int>();
            foreach (var machinePair in _machines)
            {
                if (machinePair.Value.UserIds.ContainsKey(userId))
                {
                    machineIds.Add(machinePair.Key);
                }
            }

            return machineIds.ToArray();
        }

        /// <summary>
        /// 1) Remove UserIds that were set many days ago.
        /// 2) Remove Machine records that have no UserId subscription left.
        /// </summary>
        public static void PurgeOld(int days)
        {
            var oldDate = DateTime.Now.AddDays(-days);
            foreach (var subscribedMachine in _machines.Values)
            {
                foreach (var userIdPair in subscribedMachine.UserIds)
                {
                    if (userIdPair.Value < oldDate)
                    {
                        DateTime date;
                        subscribedMachine.UserIds.TryRemove(userIdPair.Key, out date);
                    }
                }
                if (subscribedMachine.UserIds.Count == 0)
                {
                    SubscribedMachine removedMachine;
                    _machines.TryRemove(subscribedMachine.MachineId, out removedMachine);
                }
            }
            SaveToFile();
        }


        #region Private Methods


        private static void SaveToFile()
        {
            lock (ThisLock)
            {
                if (File.Exists(SubscriptionFileName))
                {
                    File.Delete(SubscriptionFileName);
                }
                try
                {
                    var json = JsonConvert.SerializeObject(_machines);
                    File.WriteAllText(SubscriptionFileName, json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private static void ReadFromFile()
        {
            lock (ThisLock)
            {
                if (File.Exists(SubscriptionFileName))
                {
                    try
                    {
                        var json = File.ReadAllText(SubscriptionFileName);
                        _machines = JsonConvert.DeserializeObject<ConcurrentDictionary<int, SubscribedMachine>>(json);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                _machines = new ConcurrentDictionary<int, SubscribedMachine>();
            }
        }


        #endregion

    }
}