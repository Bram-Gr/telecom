﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserDto
    {
        Guid Guid { get; set; }
        string Username { get; set; }   
        string Password { get; set; }   
        string Email { get; set; }  

    }
}
