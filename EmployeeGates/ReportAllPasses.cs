using EmployeeGates.Models;
using EmployeeGates.ReportItem;
using EmployeeGates.Repositories;
using System.Collections.Generic;


namespace EmployeeGates
{
    class ReportAllPasses
    {
        private GatesRepository _gatesRepository = new GatesRepository();
        private EmployeeRepository _employeeRepository;

        public ReportAllPasses(GatesRepository gatesRepository, EmployeeRepository employeeRepository)
        {
            _gatesRepository    = gatesRepository;
            _employeeRepository = employeeRepository;
        }

        public List<ReportItemPasses> GetAllPasses()
        {
            List<Employee> employees        = _employeeRepository.GetEmployees();
            List<ReportItemPasses> passList = new List<ReportItemPasses>();


            foreach (var employee in employees)
            {
                var reportItemPasses    = new ReportItemPasses();
                int ammountOfBreaks     = employee.LunchAmmount + employee.SmokeAmmount + employee.ToiletAmmount;

                reportItemPasses.AmmountOfPasses    = (ammountOfBreaks * 2) + 2;  //    start/end of day plus breaks
                reportItemPasses.Name               = employee.Name;

                Gates gates = _gatesRepository.GetOneGate(employee.GateId);
                reportItemPasses.NameOfGates = gates.GateName;

                passList.Add(reportItemPasses);
            }
            return passList;
        }
    }
}
