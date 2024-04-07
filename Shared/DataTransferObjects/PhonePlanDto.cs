using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class PhonePlanDto
    {
  

        [Column("PlanName")]
        public string? PlanName { get; set; }

        [Column("DeviceLimit")]
        public int DeviceLimit { get; set; }


        [Column("Price")]

        public double Price { get; set; }

        [Column("Other plan details")]
        public string? OtherPlanDetails { get; set; }
    }
}
