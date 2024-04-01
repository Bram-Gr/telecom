using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Entities
{
    public class UserPhonePlan
    {
        [ForeignKey(nameof(User))]
        public Guid UserID { get; set; }

        [ForeignKey(nameof(PhonePlan))]
        public Guid PlanID { get; set; }
    }
}
/*User_PhonePlan table(Many-to-Many relationship between User and PhonePlan):

UserID(Foreign Key referencing User table)
PlanID(Foreign Key referencing PhonePlan table)*/