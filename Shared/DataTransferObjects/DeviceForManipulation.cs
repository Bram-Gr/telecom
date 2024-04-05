using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class DeviceForManipulation
    {

        [Required(ErrorMessage = "Phone number is required.")]
        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }


        [Required(ErrorMessage = "Device details are required.")]
        [Column("Other device details")]
        public string? OtherDeviceDetails { get; set; }
    }
}
