using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MeetCapstone.Data;

namespace MeetCapstone.Models
{
    public class Meet
    {
        [Key]
        public int MeetId { get; set; }
        public string MeetName { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string MeetTime { get; set; }
        public string MeetDate { get; set; }

    }
}
