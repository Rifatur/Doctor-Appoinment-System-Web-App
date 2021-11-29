using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class Patient
    {
        [Key]
        public int PatienID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 10)]
        public string mobile { get; set; }
        public string Token { get; set; }
        public string PatienCard { get; set; }
        public int Status { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime created { get; set; }

        public virtual PatientInformation PatientInformation { get; set; }
        public virtual AccountBalance AccountBalance { get; set; }
        public virtual List<Appointment> Appointments { get; set; }

    }
}
