using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance.Model;
using Attendance.ViewModel;

namespace Attendance.DAL
{
    class AttendanceGateway : DBconnection
    {
        public string GetTotalEntry()
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM employee_educational_info";
                Connection.Open();
                Command.CommandText = query;
                int count = Convert.ToInt32(Command.ExecuteScalar());
                return count.ToString();
            }
            finally
            {
                Connection.Close();
            }
        }

        public int IsRfidValid(string rfid)
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM rfid_info WHERE rfid = @rfid";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@rfid", rfid);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                return count;
            }
            finally
            {
                Connection.Close();
            }
        }



        internal int IsWeekend(string day)
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM weekend_definition WHERE weekend LIKE @day";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@day", day);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                return count;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int IsHoliday(string date, int month, int year)
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM holiday_definition WHERE holiday_dates LIKE @date AND month = @month AND year = @year";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@date", date);
                Command.Parameters.AddWithValue("@month", month);
                Command.Parameters.AddWithValue("@year", year);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                return count;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int IsAttendanceStatusExsits(string userId, string localTime)
        {
            try
            {
                const string query = @"SELECT COUNT(*) FROM employee_attendance_info WHERE user_id = @userId AND local_time = @localTime";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@userId", userId);
                Command.Parameters.AddWithValue("@localTime", localTime);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                return count;
            }
            finally
            {
                Connection.Close();
            }
        }

        public string GetUserIdByRfid(string rfid)
        {
            try
            {
                const string query = @"SELECT user_id FROM rfid_info WHERE rfid = @rfid";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@rfid", rfid);
                Reader = Command.ExecuteReader();
                Reader.Read();
                string userId = Reader["user_id"].ToString();
                Reader.Close();
                return userId;
            }
            finally
            {
                Connection.Close();
            }
        }

        public AttendanceDefinition GetAttenanceDefinition()
        {
            try
            {
                const string query = @"SELECT * FROM attendance_definition";
                Connection.Open();
                Command.CommandText = query;
                Reader = Command.ExecuteReader();
                Reader.Read();
                AttendanceDefinition attendanceDefinition = new AttendanceDefinition
                {
                    EntryTime = Reader["entry_time"].ToString(),
                    LeavingTime = Reader["leaving_time"].ToString(),
                };
                Reader.Close();
                return attendanceDefinition;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int AddLeavingStatus(EmployeeAttendance employeeAttendance)
        {
            try
            {
                const string query = @"INSERT INTO employee_attendance_info(user_id, entry_time, years, months, day, local_time, status, fine) 
                                       VALUES(@userId, @entryTime, @years, @months, @day, @localTime, @status, @fine)";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@userId", employeeAttendance.UserId);
                Command.Parameters.AddWithValue("@entryTime", employeeAttendance.EntryTime);
                Command.Parameters.AddWithValue("@years", employeeAttendance.Years);
                Command.Parameters.AddWithValue("@months", employeeAttendance.Months);
                Command.Parameters.AddWithValue("@day", employeeAttendance.Day);
                Command.Parameters.AddWithValue("@localTime", employeeAttendance.LocalTime);
                Command.Parameters.AddWithValue("@status", employeeAttendance.Status);
                Command.Parameters.AddWithValue("@fine", employeeAttendance.Fine);
                int count = Command.ExecuteNonQuery();
                return count;
            }
            finally
            {
                Connection.Close();
            }
        }

        public EmployeeProfileRfid GetEmployeeInfo(string rfid)
        {
            try
            {
                const string query = @"SELECT p.name, p.img_name, p.user_id FROM rfid_info r 
                                      JOIN employee_profile_info p 
                                      ON r.user_id = p.user_id AND r.rfid_id= @rfid";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@rfid", rfid);
                Reader = Command.ExecuteReader();
                Reader.Read();
                EmployeeProfileRfid employeeProfileRfid = new EmployeeProfileRfid
                {
                    ProfileImage = "http://localhost/eps/" + Reader["img_name"],
                    EmployeeName = Reader["name"].ToString(),
                    EmployeeId = Reader["user_id"].ToString(),
                };
                Reader.Close();
                return employeeProfileRfid;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
