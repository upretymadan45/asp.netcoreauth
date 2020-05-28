using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
