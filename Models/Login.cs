﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Angular4.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string  Password { get; set; }
    }
}
