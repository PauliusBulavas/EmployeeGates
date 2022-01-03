using EmployeeGates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGates.Repositories
{
    public class GatesRepository
    {
        private List<Gates> gates = new List<Gates>();

        public GatesRepository()
        {
            gates.Add(new Gates(1, "North gate"));
            gates.Add(new Gates(2, "East gate"));
            gates.Add(new Gates(3, "South gate"));
            gates.Add(new Gates(4, "West gate"));
        }

        public Gates GetOneGate(int id)
        {
            var actualGate = gates.FirstOrDefault(x => x.Id == id);

            return actualGate;
        }
    }
}
