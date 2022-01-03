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

        public ReportWorkHours(EventRepository eventRepository, EmployeeRepository employeeRepository)
        {
            _eventRepository    = eventRepository;
            _employeeRepository = employeeRepository;
        }

        public List<ReportItemWorkHours> GetAllWorkHours()
        {
            List<Employee> employees = _employeeRepository.GetEmployees();
            List<ReportItemWorkHours> workHours = new List<ReportItemWorkHours>();


            foreach (var employee in employees)
            {
                var reportItemWorkHours = new ReportItemWorkHours();

                TimeSpan lunchTime = EventRepository.GetEvent("Lunch Break");

                TimeSpan workTime = new TimeSpan(9, 0, 0);
                reportItemWorkHours.Name = employee.Name;
                reportItemWorkHours.WorkTime = workTime;
                workHours.Add(reportItemWorkHours);
            }
            return workHours;
        }
    }
}
