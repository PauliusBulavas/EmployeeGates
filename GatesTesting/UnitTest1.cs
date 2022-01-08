using EmployeeGates.Repositories;
using NUnit.Framework;
using System;

namespace GatesTesting
{
    public class Tests
    {
        [Test]
        public void GetEmoployeeNameById()
        {
            var employeeRepository = new EmployeeRepository();

            string name = "Algis";

            var actualResult = employeeRepository.GetEmployee(3);

            Assert.AreEqual(name, actualResult.Name);
        }

        [Test]
        public void GetEventByName()
        {
            var eventRepository = new EventRepository();

            string eventName = "Smoke Break";

            var actualResult = eventRepository.GetEvent("Smoke Break");

            Assert.AreSame(eventName, actualResult.NameOfEvent);
        }

        [Test]
        public void GetGatesById()
        {
            var gatesRepository = new GatesRepository();

            string gateName = "South gate";

            var actualResult = gatesRepository.GetOneGate(3);

            Assert.AreSame(gateName, actualResult.GateName);
        }

        [Test]
        public void GetEventTimeSpanByEventId()
        {
            var eventRepository = new EventRepository();

            TimeSpan getTime = new TimeSpan(00, 15, 00);

            var acctualResult = eventRepository.GetEventTime(2);

            Assert.AreEqual(getTime, acctualResult);
        }
    }
}