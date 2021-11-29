using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class AccountBalance
    {
        [Key]
        public int AccountId { get; set; }
        public double TotalAmount { get; set; }
        public int AccountStatus { get; set; }
        public int PatienID { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
