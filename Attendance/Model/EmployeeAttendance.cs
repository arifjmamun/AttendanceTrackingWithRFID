using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    class EmployeeAttendance
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EntryTime { get; set; }
        public string LeavingTime { get; set; }
        public string Years { get; set; }
        public string Months { get; set; }
        public string Day { get; set; }
        public string LocalDate { get; set; }
        public int Status { get; set; }
        public decimal Fine { get; set; }
    }
}
