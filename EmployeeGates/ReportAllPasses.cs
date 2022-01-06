using EmployeeGates.Models;
using EmployeeGates.ReportItem;
using EmployeeGates.Repositories;
using System.Collections.Generic;


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
                var reportItemPasses    = new ReportItemPasses();
                int ammountOfBreaks     = _eventRepository.SmokeAmmount() + _eventRepository.ToiletAmmount() + _eventRepository.LunchAmmount();

                reportItemPasses.AmmountOfPasses    = 2 + (ammountOfBreaks * 2);  //    start/end of day plus breaks
                reportItemPasses.Name               = employee.Name;

                Gates gates = _gatesRepository.GetOneGate(employee.GateId);
                reportItemPasses.NameOfGates = gates.GateName;

                passList.Add(reportItemPasses);
            }
            return passList;
        }
    }
}
