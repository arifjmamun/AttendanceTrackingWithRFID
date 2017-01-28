using System;
using System.Collections;
using Attendance.DAL;
using Attendance.Model;

namespace Attendance.BLL
{
    class AdminManager
    {
        AdminGateway _adminGateway = new AdminGateway();

        public ArrayList Login(Admin admin)
        {
            ArrayList checkList = CheckEmptyFields(admin);
            if ((bool)checkList[0])
            {
                if (IsCredentialMatch(admin))
                {
                    var dbAdmin = _adminGateway.Login(admin);
                    if (String.Equals(dbAdmin.UserId, admin.UserId, StringComparison.CurrentCulture) &&
                        String.Equals(dbAdmin.Password, admin.Password, StringComparison.CurrentCulture))
                    {
                        return new ArrayList { true, "Logged in!" };
                    }
                    return new ArrayList { false, "Invalid Credential! UserId and Password not matched!" };
                }
                return new ArrayList { false, "Invalid Credential! UserId and Password not matched!" };
            }
            return checkList;
        }

        private ArrayList CheckEmptyFields(Admin admin)
        {
            if (String.IsNullOrEmpty(admin.UserId) && String.IsNullOrEmpty(admin.Password))
            {
                return new ArrayList { false, "UserId and Password cannot be empty!" };
            }
            if (String.IsNullOrEmpty(admin.UserId))
            {
                return new ArrayList { false, "UserId cannot be empty!" };
            }
            if (String.IsNullOrEmpty(admin.Password))
            {
                return new ArrayList { false, "Password cannot be empty!" };
            }
            return new ArrayList { true };
        }

        private bool IsCredentialMatch(Admin admin)
        {
            int countUser = _adminGateway.IsCredentialMatch(admin);
            return countUser > 0;
        }
    }
}
