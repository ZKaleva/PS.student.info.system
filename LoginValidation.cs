﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginz
{
    public class LoginValidation
    {
        public static UserRoles currentUserRole { get; private set; }


        public bool ValidateUserInput()
        {
            currentUserRole = UserRoles.ADMIN;
            return true;
        }
    }
}