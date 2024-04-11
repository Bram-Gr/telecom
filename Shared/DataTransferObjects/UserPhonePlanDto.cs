using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserPhonePlanDto
    {
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(PhonePlan))]
        public Guid PhonePlanId { get; set; }
    }
}
