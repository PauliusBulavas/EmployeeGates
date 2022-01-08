using EmployeeGates.Models;
using EmployeeGates.ReportItem;
using EmployeeGates.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGates
{
    class ReportWorkHours
    {
        private EventRepository     _eventRepository = new EventRepository();
        private EmployeeRepository  _employeeRepository;
        private GatesRepository     _gatesRepository;

        public ReportWorkHours(EventRepository eventRepository, EmployeeRepository employeeRepository, GatesRepository gatesRepository)
        {
            _eventRepository        = eventRepository;
            _employeeRepository     = employeeRepository;
            _gatesRepository        = gatesRepository;
        }

        public List<ReportItemWorkHours> GetAllWorkHours()
        {
            var reportAllPasses = new ReportAllPasses(_gatesRepository, _employeeRepository, _eventRepository);

            List<Employee> employees = _employeeRepository.GetEmployees();
            List<ReportItemPasses> allPasses = reportAllPasses.GetAllPasses();
            List<ReportItemWorkHours> workHours = new List<ReportItemWorkHours>();


            foreach (var employee in employees)
            {
                var reportItemWorkHours = new ReportItemWorkHours();

                TimeSpan lunchTime  = _eventRepository.GetEventTime(1) * _eventRepository.LunchAmmount();
                TimeSpan smokeTime  = _eventRepository.GetEventTime(2) * _eventRepository.SmokeAmmount();
                TimeSpan toiletTime = _eventRepository.GetEventTime(3) * _eventRepository.ToiletAmmount();

                TimeSpan workTime = new TimeSpan(9, 0, 0) - lunchTime - smokeTime - toiletTime;
                reportItemWorkHours.Name = employee.Name;
                reportItemWorkHours.WorkTime = workTime;
                reportItemWorkHours.TimeSpentLunch = lunchTime;
                reportItemWorkHours.TimeSpentSmoking = smokeTime;
                reportItemWorkHours.TimeSpentToilet = toiletTime;
                workHours.Add(reportItemWorkHours);
            }
            return workHours;
        }
    }
}
