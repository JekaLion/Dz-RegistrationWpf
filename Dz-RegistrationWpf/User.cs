﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_RegistrationWpf
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string imagePath { get; set; }
        public string AboutMe { get; set; }

        public User()
        {

        }
    }
}
