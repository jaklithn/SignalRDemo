using System.Collections.Generic;
using System.Linq;
using Demo.Web.Models;

namespace Demo.Web.Services
{
    public class MachineRepository
    {
        
        public List<MachineModel> GetMachines()
        {
            var machines = new List<MachineModel>
            {
                new MachineModel {Id = 1343},
                new MachineModel {Id = 1399},
                new MachineModel {Id = 2909},
                new MachineModel {Id = 3237},
                new MachineModel {Id = 3264},
                new MachineModel {Id = 3292},
                new MachineModel {Id = 3957},
                new MachineModel {Id = 4544},
                new MachineModel {Id = 4545},
                new MachineModel {Id = 4620},
            };
            return machines;
        }

        public MachineModel GetMachine(int machineId)
        {
            return GetMachines().Single(x => x.Id == machineId);
        }		

		public static string GetUrlForGeneratedPicture(int machineId)
		{
			return $"/Content/images/ScreenDump{machineId}.jpg";
		}
    }
}