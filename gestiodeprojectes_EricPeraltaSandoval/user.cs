﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public class user
    {
        public String name { get; set; } 
        public String surname { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public int userId { get; set; }

        public user() { 
        }

        public user(String name, String surname, String email, String password, int userId) { 
            this.name = name;  
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.userId = userId;
        }

    }
}
