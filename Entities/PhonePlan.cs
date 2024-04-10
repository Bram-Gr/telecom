using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PhonePlan
    {
        [Column("PlanID")]
        public Guid Id { get; set; }

        [Column("PlanName")]
        public string? PlanName { get; set; }

        [Column("DeviceLimit")]
        public int DeviceLimit { get; set; }


        [Column("Price")]

        public double Price { get; set; }

        [Column("Other plan details")]
        public string? OtherPlanDetails { get; set; }


        public List<User> User { get; set; }
    }
}
/*PhonePlan table:

PlanID(Primary Key)
PlanName
DeviceLimit
Price
Other plan details*/