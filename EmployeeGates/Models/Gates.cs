using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGates.Models
{
    public class Gates
    {
        public int      Id      { get; set; }
        public string   GateName    { get; set; }
        public Gates()
        {

        }

        public Gates(int id, string gateName)
        {
            Id          = id;
            GateName    = gateName;
        }
    }
}
