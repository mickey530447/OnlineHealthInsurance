﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineHealthInsurance.Models
{
    public class Admin
    {
        public Admin()
        {

        }
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}