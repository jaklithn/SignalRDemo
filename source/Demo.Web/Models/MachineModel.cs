namespace Demo.Web.Models
{
    public class MachineModel
    {
        public int Id { get; set; }
        public string ScreenDumpUrl { get; set; }

        public string Name => $"Cs{Id}";

    }
}