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
            var reportAllPasses     = new ReportAllPasses(gatesRepository, employeeRepository, eventRepository);
            var reportWorkHours     = new ReportWorkHours(eventRepository, employeeRepository);

            List<ReportItemPasses> allPasses        = reportAllPasses.GetAllPasses();
            List<ReportItemWorkHours> allWorkHours  = reportWorkHours.GetAllWorkHours();

            Console.WriteLine("Gate access report: ");
            foreach (var item in allPasses)
            {
                Console.WriteLine($"{item.Name} passed the {item.NameOfGates} the ammount of {item.AmmountOfPasses} times");
            }
            Console.WriteLine("Hours worked:  ");
            foreach (var item in allWorkHours)
            {
                Console.WriteLine($"{item.Name} worked a total of {item.WorkTime} time");
            }
        }
    }
}
