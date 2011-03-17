using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class Company
    {
        public string CompanyName { get; set; }
        public CompanySizeEnum CompanySize { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
    }
}