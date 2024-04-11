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
    public class DeviceForManipulationDto
    {

        [Column("DeviceID")]
        public Guid Id { get; set; }

        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserID { get; set; }

        [ForeignKey(nameof(PhonePlan))]
        public Guid PhonePlanID { get; set; }

        [Column("Other device details")]
        public string? OtherDeviceDetails { get; set; }

    }
}
