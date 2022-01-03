using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGates.Models
{
    public class Employee
    {
        public int      EmployeeId          { get; set; }
        public string   Name                { get; set; }
        public int      GateId              { get; set; }
        public int      LunchAmmount        { get; set; }
        public int      SmokeAmmount        { get; set; }
        public int      ToiletAmmount       { get; set; }

        public Employee()
        {

        }

        public Employee(int employeeId, string name, int gateId, int lunchAmmount, int smokeAmmount, int toiletAmmount)
        {
            EmployeeId      = employeeId;
            Name            = name;
            GateId          = gateId;
            LunchAmmount    = lunchAmmount;
            SmokeAmmount    = smokeAmmount;
            ToiletAmmount   = toiletAmmount;
        }
    }
}
