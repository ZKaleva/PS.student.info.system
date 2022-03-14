using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginz
{
    static public class UserData
    {
        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        private static User _testUser;

        static private void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User();
                _testUser.UserName = "Zdravena";
                _testUser.Password = "123456";
                _testUser.FacNumber = "501219003";
                _testUser.Role = 0;
            }
        }
    }
}