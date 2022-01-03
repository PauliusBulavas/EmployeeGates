using EmployeeGates.ReportItem;
using EmployeeGates.Repositories;
using System;
using System.Collections.Generic;

namespace EmployeeGates
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventRepository     = new EventRepository();
            var gatesRepository     = new GatesRepository();
            var employeeRepository  = new EmployeeRepository();
            var reportAllPasses     = new ReportAllPasses(gatesRepository, employeeRepository);
            var reportWorkHours     = new ReportWorkHours(eventRepository, employeeRepository);

            List<ReportItemPasses> allPasses = reportAllPasses.GetAllPasses();
            List<ReportItemWorkHours> allWorkHours = reportWorkHours.GetAllWorkHours();

            Console.WriteLine("report: ");
            foreach (var item in allPasses)
            {
                Console.WriteLine($"{item.Name}, praejo pro {item.NameOfGates} vartu {item.AmmountOfPasses} kartu");
            }
            Console.WriteLine("valandos:  ");
            foreach (var item in allWorkHours)
            {
                Console.WriteLine($"{item.Name}, isdirbo {item.WorkTime}");
            }
        }
    }
}
