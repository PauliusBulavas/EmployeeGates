using EmployeeGates.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeGates.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeRepository()
        {
            employees.Add(new Employee(1,   "Petras"    , 1, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(2,   "Jonas"     , 1, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(3,   "Algis"     , 2, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(4,   "Antanas"   , 2, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(5,   "Romas"     , 3, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(6,   "Zigmas"    , 3, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(7,   "Jolanta"   , 4, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(8,   "Angele"    , 4, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(9,   "Juozapas"  , 2, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
            employees.Add(new Employee(10,  "Mantas"    , 1, LunchAmmount(), SmokeAmmount(), ToiletAmmount()));
        }

        public int LunchAmmount()
        {
            var random = new Random();
            int lunchBreakAmmount = random.Next(0, 2);

            return lunchBreakAmmount;
        }
        public int SmokeAmmount()
        {
            var random = new Random();
            int smokeBreakAmmount = random.Next(0, 6);

            return smokeBreakAmmount;
        }
        public int ToiletAmmount()
        {
            var random = new Random();
            int toiletBreakAmmount = random.Next(0, 4);

            return toiletBreakAmmount;
        }

        public List<Employee> GetEmployees() => employees;
        public Employee GetEmployee(int employeeId)
        {
            var actualEmployee = employees.FirstOrDefault(x => x.EmployeeId == employeeId);

            return actualEmployee;
        }
    }
}
