using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace OnlineHealthInsurance.Models
{
    public class Hospital
    {
        public Hospital()
        {

        }
        [Key]
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
    }
}