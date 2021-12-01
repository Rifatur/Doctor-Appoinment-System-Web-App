using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class DoctorImage
    {
        [Key]
        public int DimageID { get; set; }
        public string doctorImage { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
