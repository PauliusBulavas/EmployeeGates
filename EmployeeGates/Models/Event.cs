using System;

namespace EmployeeGates
{
    public class Event
    {
        public string       NameOfEvent { get; set; }
        public TimeSpan     Span        { get; set; }

        public Event()
        {

        }

        public Event(string nameOfEvent, TimeSpan span)
        {
            NameOfEvent = nameOfEvent;
            Span        = span;
        }
    }
}
