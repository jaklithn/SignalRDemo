using System;
using System.Collections.Concurrent;

namespace Demo.Web.Models
{
    public class SubscribedMachine
    {
        public int MachineId { get; private set; }

		/// <summary>
		/// There is no ConcurrentHashSet so we use a ConcurrentDictionary and use the value position to store the time of creation.
		/// </summary>
		public ConcurrentDictionary<string, DateTime> UserIds { get; private set; }

        public SubscribedMachine(int machineId)
        {
            MachineId = machineId;
            UserIds = new ConcurrentDictionary<string, DateTime>();
        }
    }
}