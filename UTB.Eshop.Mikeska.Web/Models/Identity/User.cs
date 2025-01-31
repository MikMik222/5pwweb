﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTB.Eshop.Mikeska.Web.Models.Identity
{
    public class User : IdentityUser<int>
    {
        public User() : base()
        {

        }

        public User(string userName) : base(userName)
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
