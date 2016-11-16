namespace Demo.WinApp.Entities
{
    public class Machine
    {
        public int Id { get; set; }

        public string Name => $"Cs{Id}";

    }
}