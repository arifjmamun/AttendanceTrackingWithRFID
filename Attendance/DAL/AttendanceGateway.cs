using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public int IsHoliday(string date, int month, int year)
        {

            return 0;
        }
    }
}
