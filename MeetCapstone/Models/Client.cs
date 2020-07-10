using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MeetCapstone.Data;
using Microsoft.AspNetCore.Identity;

namespace MeetCapstone.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<Client> Friends { get; set; }
        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
}
}
