using System;
using System.Windows.Forms;
using Attendance.Model;
using MySql.Data.MySqlClient;

namespace Attendance.DAL
{
    class AdminGateway : DBconnection
    {
        public int IsCredentialMatch(Admin admin)
        {
            try
            {
                const string query =
                    @"SELECT COUNT(*) FROM admin_info WHERE ap_user_id = @UserId AND user_passcode = @Password";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@UserId", admin.UserId);
                Command.Parameters.AddWithValue("@Password", admin.Password);
                int countUser = Convert.ToInt32(Command.ExecuteScalar());
                return countUser;
            }
            catch (MySqlException)
            {
                MessageBox.Show(@"Connection Problem. Check Again.");
                return 0;
            }
            finally
            {
                Connection.Close();
            }
        }

        public Admin Login(Admin admin)
        {
            try
            {
                var dbAdmin = new Admin();
                const string query = @"SELECT ap_user_id, user_passcode FROM admin_info WHERE ap_user_id = @UserId AND user_passcode = @Password";
                Connection.Open();
                Command.CommandText = query;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@UserId", admin.UserId);
                Command.Parameters.AddWithValue("@Password", admin.Password);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Reader.Read();
                    dbAdmin.UserId = Reader["ap_user_id"].ToString();
                    dbAdmin.Password = Reader["user_passcode"].ToString();
                }
                Reader.Close();
                return dbAdmin;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
