using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineHealthInsurance.Models
{
    public class CompanyDetail
    {
        public CompanyDetail()
        {

        }
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CompanyURL { get; set; }

        public ICollection<Policy> Policies { get; set; }

    }
}