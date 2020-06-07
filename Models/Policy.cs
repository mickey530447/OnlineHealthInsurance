using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineHealthInsurance.Models
{
    public class Policy
    {
        public Policy()
        {

        }
        [Key]
        public int PolicyID { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDescription { get; set; }
        public decimal Amount { get; set; }
        public decimal Emi { get; set; }
        public int CompanyID { get; set; }
        public string MedicalID { get; set; }

        public CompanyDetail CompanyDetail { get; set; }
    }
}