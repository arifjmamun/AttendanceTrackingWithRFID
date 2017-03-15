using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance.DAL;
using Attendance.ViewModel;

namespace Attendance.BLL
{
    class AttendanceManager
    {
        AttendanceGateway _attendanceGateway = new AttendanceGateway();
        public string GetTotalEntry()
        {
            return _attendanceGateway.GetTotalEntry();
        }

        public EmployeeProfileRfid AssignAttendanceInfo(string rfid)
        {
            if (IsRfidValid(rfid))
            {
                if (!IsWeekend() && !IsHoliday())
                {

                }
            }
            return null;
        }

        private bool IsHoliday()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int countRow = _attendanceGateway.IsHoliday(date, month, year);
            return countRow > 0;
        }

        private bool IsWeekend()
        {
            string day = DateTime.Now.ToString("dddd");
            int countRow = _attendanceGateway.IsWeekend(day);
            return countRow > 0;
        }

        private bool IsRfidValid(string rfid)
        {
            int countRow = _attendanceGateway.IsRfidValid(rfid);
            return countRow > 0;
        }
    }
}
