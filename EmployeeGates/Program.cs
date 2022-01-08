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
            var reportWorkHours     = new ReportWorkHours(eventRepository, employeeRepository, gatesRepository);

            List<ReportItemPasses> allPasses        = reportAllPasses.GetAllPasses();
            List<ReportItemWorkHours> allWorkHours  = reportWorkHours.GetAllWorkHours();

            Console.WriteLine("Gate access report: ");
            foreach (var item in allPasses)
            {
                Console.WriteLine($"{item.Name} passed the {item.NameOfGates} the ammount of {item.AmmountOfPasses} times");
                Console.WriteLine($"To have lunch: {item.AmmountOfLunchBreaks}");
                Console.WriteLine($"To have a smoke: {item.AmmountOfSmokeBreaks}");
                Console.WriteLine($"WC times {item.AmmountOfToiletBreaks}");
                Console.WriteLine("");
            }
            Console.WriteLine("Hours worked:  ");
            foreach (var item in allWorkHours)
            {
                Console.WriteLine($"{item.Name} worked a total of {item.WorkTime} time");
                Console.WriteLine($"time at lunch {item.TimeSpentLunch}");
                Console.WriteLine($"time smoking {item.TimeSpentSmoking}");
                Console.WriteLine($"time at the toilet {item.TimeSpentToilet}");
                Console.WriteLine("");
            }
        }
    }
}
