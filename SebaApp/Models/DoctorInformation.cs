using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class DoctorInformation
    {
        [Key]
        public int infoID { get; set; }

        public string SpecialistIn { get; set; }
        public string Experiance { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string About { get; set; }
        [Required]
        public string Hospital { get; set; }
        public string officeAddress { get; set; }
        public string MailingAddress { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        public string Area { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateofBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Nid { get; set; }
        public string Nationality { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
