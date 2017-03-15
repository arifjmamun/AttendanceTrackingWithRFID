using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance.DAL;

namespace Attendance.Model
{
    class AttendanceDefinition
    {
        public int Id { get; set; }
        public string EntryTime { get; set; }
        public string LeavingTime { get; set; }

        public static AttendanceDefinition GetDefinition()
        {
            AttendanceGateway _attendanceGateway = new AttendanceGateway();
            return _attendanceGateway.GetAttenanceDefinition();
        }
    }
}
