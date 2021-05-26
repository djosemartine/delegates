using System;

namespace Events
{
    public class Sender
    {
        public Guid MessageId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
