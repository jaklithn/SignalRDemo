using System.Collections.Generic;
using Demo.WinApp.Entities;


namespace Demo.WinApp.Services
{
	public class MachineRepository
	{
		public List<Machine> GetMachines()
		{
			var machines = new List<Machine>
			{
				new Machine {Id = 1343},
				new Machine {Id = 1399},
				new Machine {Id = 2909},
				new Machine {Id = 3237},
				new Machine {Id = 3264},
				new Machine {Id = 3292},
				new Machine {Id = 3957},
				new Machine {Id = 4544},
				new Machine {Id = 4545},
				new Machine {Id = 4620},
			};
			return machines;
		}
	}
}