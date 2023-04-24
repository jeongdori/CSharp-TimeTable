using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{

    [Serializable]
    public class Schedule
    {
        public Schedule() { }

        public string? Time { get; set; }
        public string? Mon { get; set; }
        public string? Tue { get; set; }
        public string? Wed { get; set; }
        public string? Thu { get; set; }
        public string? Fri { get; set; }
        
    }
}
