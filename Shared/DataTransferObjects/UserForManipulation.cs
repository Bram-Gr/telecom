using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserForManipulation
    {
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(50, ErrorMessage = "Username must be less than 50 characters.")]
        [Column("Username")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(50, ErrorMessage = "Password must be less than 50 characters.")]
        [Column("Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50, ErrorMessage = "Email must be less than 50 characters.")]
        [Column("Email")]
        public string? Email { get; set; }
    }
}
