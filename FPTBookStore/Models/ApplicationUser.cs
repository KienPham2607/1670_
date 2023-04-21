﻿using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using KTBook.Models;
using System;

namespace KTBook.Models
{
    
    public class ApplicationUser:IdentityUser
    {
        public string Image { get;set; }
        public string FullName { get; set; }
        public string DoB { get; set; }
        public string Address { get; set; }

    }
}
