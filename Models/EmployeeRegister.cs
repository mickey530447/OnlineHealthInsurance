﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineHealthInsurance.Models
{
    public class EmployeeRegister
    {
        public EmployeeRegister()
        {

        }
        [Key]
        public int EmployeeID { get; set; }
        public string Designation { get; set; }
        /*public DateTime JoinDate
        {
            get
            {
                return joinDate ?? DateTime.Now;
            }
            set { this.joinDate = value;  }
        }*/
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime JoinDate { get; set; }
        public decimal Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PolicyStatus { get; set; }
        public int  PolicyID { get; set; }
    }
}
