using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGates.Repositories
{
    public class EventRepository
    {
        private List<Event> events = new List<Event>();

        public EventRepository()
        {
            events.Add(new Event("Lunch Break",  new TimeSpan(01, 00, 00)));
            events.Add(new Event("Smoke Break",  new TimeSpan(00, 15, 00)));
            events.Add(new Event("Toilet Break", new TimeSpan(00, 10, 00)));
        }

        public List<Event> GetEvent() => events;

        public Event GetEvent(string oneEvent)
        {
            var acctualEvent = events.FirstOrDefault(x => x.NameOfEvent == oneEvent);

            return acctualEvent;
        }
    }
}
