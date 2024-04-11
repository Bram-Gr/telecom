using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Entities
{
    public class UserPhonePlan
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /*        [ForeignKey(nameof(User))]*/
        public Guid UserId { get; set; }
        /*
                [ForeignKey(nameof(PhonePlan))]*/
        public Guid PhonePlanId { get; set; }

        [Column("Date Added")]
        public DateTime? DateAdded { get; set; }


        /*
                public User? User { get; set; } = null!;
                public PhonePlan? PhonePlan { get; set; } = null!;
            }*/
    }
}
/*User_PhonePlan table(Many-to-Many relationship between User and PhonePlan):

UserID(Foreign Key referencing User table)
PlanID(Foreign Key referencing PhonePlan table)*/