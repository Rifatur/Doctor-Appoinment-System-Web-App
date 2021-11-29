using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class PatientInformation
    {
        [Key]
        public int PatientinfoID { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateofBirth { get; set; }
        public string weight { get; set; }
        public string Height { get; set; }
        public string Bloodgroup { get; set; }
        public string MailingAddress { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        public string Area { get; set; }

        public int PatienID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
