namespace Demo.Web.Models
{
    public enum MessageType
    {
        Info,
        Success,
        Warning,
        Error
    }

    public class Notification
    {
        public string MessageType { get; set; }
        public string Header { get; set; }
        public string Message { get; set; }

        public Notification(MessageType messageType, string header, string message)
        {
            MessageType = messageType.ToString();
            Header = header;
            Message = message;
        }
    }
}