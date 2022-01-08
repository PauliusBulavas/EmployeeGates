using EmployeeGates.Models;
using EmployeeGates.ReportItem;
using EmployeeGates.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeGates
{
    class ReportAllPasses
    {
        private GatesRepository     _gatesRepository = new GatesRepository();
        private EmployeeRepository  _employeeRepository;
        private EventRepository     _eventRepository;

        public ReportAllPasses(GatesRepository gatesRepository, EmployeeRepository employeeRepository, EventRepository eventRepository)
        {
            _gatesRepository    = gatesRepository;
            _employeeRepository = employeeRepository;
            _eventRepository    = eventRepository;
        }

        public List<ReportItemPasses> GetAllPasses()
        {
            List<Employee> employees        = _employeeRepository.GetEmployees();           
            List<ReportItemPasses> passList = new List<ReportItemPasses>();


            foreach (var employee in employees)
            {
                var reportItemPasses        = new ReportItemPasses();
                int ammountSmokeBreaks      = _eventRepository.SmokeAmmount();
                int ammountOfLunchBreaks    = _eventRepository.LunchAmmount();
                int ammountOfToiletBreaks   = _eventRepository.ToiletAmmount();

                reportItemPasses.AmmountOfSmokeBreaks   = ammountSmokeBreaks;
                reportItemPasses.AmmountOfToiletBreaks  = ammountOfToiletBreaks;
                reportItemPasses.AmmountOfLunchBreaks   = ammountOfLunchBreaks;
                reportItemPasses.AmmountOfPasses        = 2 + (ammountOfLunchBreaks * 2) + (ammountSmokeBreaks * 2) + (ammountOfToiletBreaks * 2);
                
                reportItemPasses.Name = employee.Name;

                Gates gates = _gatesRepository.GetOneGate(employee.GateId);
                reportItemPasses.NameOfGates = gates.GateName;

                passList.Add(reportItemPasses);
            }
            return passList;
        }
    }
}
