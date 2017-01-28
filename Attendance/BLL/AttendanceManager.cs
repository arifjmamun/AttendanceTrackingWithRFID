using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance.DAL;

namespace Attendance.BLL
{
    class AttendanceManager
    {
        AttendanceGateway _attendanceGateway = new AttendanceGateway();
        public string GetTotalEntry()
        {
            return _attendanceGateway.GetTotalEntry();
        }
    }
}
