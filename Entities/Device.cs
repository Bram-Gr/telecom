using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Device
    {
        [Column("DeviceID")]
        public Guid Id { get; set; }

        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }

        [ForeignKey(nameof(User))]  
        public Guid UserID { get; set; }

        [ForeignKey(nameof(PhonePlan))]
        public Guid PlanID { get; set; }

        [Column("Other device details")]
        public string? OtherDeviceDetails { get; set; }



    }
}
/*Device table:

DeviceID(Primary Key)
PhoneNumber(Unique)
UserID(Foreign Key referencing User table)
PlanID(Foreign Key referencing PhonePlan table)
Other device details*/