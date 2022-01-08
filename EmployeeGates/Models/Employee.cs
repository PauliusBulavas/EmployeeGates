using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGates.Models
{
    public class Employee
    {
        public int      EmployeeId  { get; set; }
        public string   Name        { get; set; }
        public int      GateId      { get; set; }


        public Employee()
        {

        }


        public Employee(int employeeId, string name, int gateId)
        {
            EmployeeId      = employeeId;
            Name            = name;
            GateId          = gateId;

        }
    }
}
