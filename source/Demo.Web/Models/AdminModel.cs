using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Demo.Web.Models
{
    public class AdminModel
    {
        public int SelectedMachineId { get; set; }
        public List<MachineModel> Machines { get; set; }

        public IEnumerable<SelectListItem> GetMachineList()
        {
            return Machines.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name, Selected = x.Id == SelectedMachineId });
        }
    }
}