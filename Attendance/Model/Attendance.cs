using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    class Attendance
    {
        public int Serial { get; set; }
        public string UserId { get; set; }
        public string EntryTime { get; set; }
        public string LeavingTime { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string LocalTime { get; set; }
        public decimal Fine { get; set; }
    }
}
