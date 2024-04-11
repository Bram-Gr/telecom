using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class User
      /*  : IdentityUser*/
    {
        [Column("UserId")]
        public Guid Id { get; set; }
       
        [Required(ErrorMessage="Username is required.")]
        [MaxLength(50, ErrorMessage="Username must be less than 50 characters.")]
        [Column("Username")]
        public string? Username { get; set; }

        [Required(ErrorMessage="Password is required.")]
        [MaxLength(50, ErrorMessage="Password must be less than 50 characters.")]
        [Column("Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage="Email is required.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50, ErrorMessage="Email must be less than 50 characters.")]
        [Column("Email")]
        public string? Email { get; set; }

        public List<PhonePlan> PhonePlans { get; } = [];/*
        public ICollection<PhonePlan> PhonePlans { get; set; } = new List<PhonePlan>();*/
        /*        public List<UserPhonePlan> UserPhonePlans { get; } = [];*/




    }
}
/*User table:

UserID(Primary Key)
Username
Password
Email
Other relevant user details*/