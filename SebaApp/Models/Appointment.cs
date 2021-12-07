using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class Appointment
    {
        [Key]
        public int appointID { get; set; }
        public string AppointmentType { get; set; }
        [Column(TypeName = "date")]
        public DateTime AppoinmentDate { get; set; }
        public string TimeSlot { get; set; }
        public string About_Appointment { get; set; }
        public int AppointmentStatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime created { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int PatienID { get; set; }
        public virtual Patient Patient { get; set; }

       

    }
}
