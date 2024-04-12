﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }   
        public string? Password { get; set; }   
        public string? Email { get; set; }  

    }
}
