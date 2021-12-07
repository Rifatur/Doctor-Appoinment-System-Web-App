using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int feeType { get; set; }
        public int paymentStatus { get; set; }
        public double PayableTotal { get; set; }
        public double DuoAmount { get; set; }
        public int appointID { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int PatienID { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
