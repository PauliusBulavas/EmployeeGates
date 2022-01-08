using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGates.ReportItem
{
    class ReportItemWorkHours
    {
        public string   Name                { get; set; }
        public TimeSpan WorkTime            { get; set; }
        public TimeSpan TimeSpentSmoking    { get; set; }
        public TimeSpan TimeSpentLunch      { get; set; }
        public TimeSpan TimeSpentToilet     { get; set; }
    }
}
