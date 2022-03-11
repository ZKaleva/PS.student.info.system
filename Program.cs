using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginValidation validation = new LoginValidation();

            if(validation.ValidateUserInput())
            {
                Console.WriteLine(User.UserName);
                Console.WriteLine(User.Password);
                Console.WriteLine(User.FacNumber);
                Console.WriteLine(User.Role);



            }
        }
    }
}
