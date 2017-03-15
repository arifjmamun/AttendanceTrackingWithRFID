using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance.DAL;
using Attendance.Model;
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
            if (!IsRfidValid(rfid)) return new EmployeeProfileRfid { Status = "Invalid Card!" };
            if (IsWeekend() || IsHoliday()) return new EmployeeProfileRfid { Status = "Its off Day!" };
            if (!IsAttendanceStatusExsits(rfid))
            {
                if (IsNowEntryTime())
                {
                    return AddEntranceStatus(rfid);
                }
                return new EmployeeProfileRfid{Status = "Invalid Entry Time"};
            }
            else
            {
                if (IsNowLeavingTime())
                {
                    return AddLeavingStatus(rfid);
                }
                return new EmployeeProfileRfid { Status = "Invalid Leaving Time." };
            }
        }

        private EmployeeProfileRfid AddLeavingStatus(string rfid)
        {
            throw new NotImplementedException();
        }

        private EmployeeProfileRfid AddEntranceStatus(string rfid)
        {
            double entryTime = Convert.ToDouble(TimeSpan.Parse(AttendanceDefinition.GetDefinition().EntryTime).TotalSeconds) + 1800;
            double nowTime = Convert.ToDouble(TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")).TotalSeconds);
            EmployeeAttendance employeeAttendance = new EmployeeAttendance()
            {
                UserId = GetUserIdByRfid(rfid),
                EntryTime = DateTime.Now.ToString("HH:mm:ss"),
                Years = DateTime.Now.Year.ToString(),
                Months = DateTime.Now.ToString("MMMM"),
                Day = DateTime.Now.ToString("dddd"),
                LocalTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Status = nowTime <= entryTime ? 1 : 0,
                Fine = nowTime <= entryTime ? 0 : 50
            };

            int countRow = _attendanceGateway.AddLeavingStatus(employeeAttendance);
            if (countRow > 0)
            {
                EmployeeProfileRfid employeeProfileRfid = _attendanceGateway.GetEmployeeInfo(rfid);
                employeeProfileRfid.AttendanceStatus = nowTime <= entryTime ? "Present" : "Late";
                employeeProfileRfid.TimeAndDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return employeeProfileRfid;
            }
            return new EmployeeProfileRfid { Status = "Something Wrong!" };
        }

        private bool IsNowLeavingTime()
        {
            var definition = AttendanceDefinition.GetDefinition();
            double nowTime = Convert.ToDouble(TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")).TotalSeconds);
            double entryTime = Convert.ToDouble(TimeSpan.Parse(definition.EntryTime).TotalSeconds);
            double leavingTime = Convert.ToDouble(TimeSpan.Parse(definition.LeavingTime).TotalSeconds);

            return nowTime>=entryTime && nowTime<=leavingTime+1800; //1800 seconds = 20minutes
        }

        private bool IsNowEntryTime()
        {
            var definition = AttendanceDefinition.GetDefinition();
            double nowTime = Convert.ToDouble(TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")).TotalSeconds);
            double entryTime = Convert.ToDouble(TimeSpan.Parse(definition.EntryTime).TotalSeconds);
            double leavingTime = Convert.ToDouble(TimeSpan.Parse(definition.LeavingTime).TotalSeconds);

            return nowTime >= entryTime && nowTime < leavingTime;
        }

        private bool IsHoliday()
        {
            string date = "%" + DateTime.Now.ToString("yyyy-MM-dd") + "%";
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int countRow = _attendanceGateway.IsHoliday(date, month, year);
            return countRow > 0;
        }

        private bool IsWeekend()
        {
            string day = "%"+DateTime.Now.ToString("dddd")+"%";
            int countRow = _attendanceGateway.IsWeekend(day);
            return countRow > 0;
        }

        private bool IsRfidValid(string rfid)
        {
            int countRow = _attendanceGateway.IsRfidValid(rfid);
            return countRow > 0;
        }

        private bool IsAttendanceStatusExsits(string rfid)
        {
            string userId = _attendanceGateway.GetUserIdByRfid(rfid);
            string localTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int countRow = _attendanceGateway.IsAttendanceStatusExsits(userId, localTime);
            return countRow > 0;
        }

        public string GetUserIdByRfid(string rfid)
        {
            return _attendanceGateway.GetUserIdByRfid(rfid);
        }
    }
}
