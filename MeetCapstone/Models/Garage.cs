using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using MeetCapstone.Data;

namespace MeetCapstone.Models
{
    public class Garage
    {
        [Key]
        public int GarageId { get; set; }
        [ForeignKey ("ClientId")]
        public Client Client { get; set; } 
        [ForeignKey ("CarId")]
        public Car Car { get; set; }


    }
}
