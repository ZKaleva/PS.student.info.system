using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginz
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoginValidation loginValidation = new LoginValidation();

            if (loginValidation.ValidateUserInput())
            {
                Console.WriteLine(UserData.TestUser.UserName);
                Console.WriteLine(UserData.TestUser.Password);
                Console.WriteLine(UserData.TestUser.FacNumber);
                Console.WriteLine(UserData.TestUser.Role);
            }

            Console.WriteLine(LoginValidation.currentUserRole);
        }
    }
}
