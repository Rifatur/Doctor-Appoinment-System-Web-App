using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        public string SetDay { get; set; }
        public string SetTime { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
