using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class VisitingPrice
    {
        [Key]
        public int priceID { get; set; }
        [Required]
        public int FirstVisit { get; set; }
        [Required]
        public int SecondVisit { get; set; }
        public int status { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
