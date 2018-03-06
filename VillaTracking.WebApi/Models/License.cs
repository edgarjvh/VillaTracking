using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VillaTracking.WebApi.Models
{
    public class License
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Status { get; set; }
    }
}