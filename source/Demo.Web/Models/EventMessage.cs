namespace Demo.Web.Models
{
    public class EventMessage
    {
        public string Type { get; private set; }
        public object Payload { get; private set; }
        public string CorrelationId { get; private set; }

        public EventMessage(string type, object payload, string correlationId = null)
        {
            Type = type;
            Payload = payload;
            CorrelationId = correlationId;
        }
    }
}