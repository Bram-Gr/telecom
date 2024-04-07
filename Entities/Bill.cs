using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;

namespace Entities
{
    public class Bill
    {
        [Column("BillID")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserID { get; set; }

        [Column("TotalAmount")]
        public double TotalAmount { get; set; }

        [Column("BillingDate")]
        public DateTime BillingDate { get; set; }

        [Column("Other bill details")]
        public string? OtherBillDetails { get; set; }

        [Column("BillingAddress")]
        public string? BillingAddress { get; set; }



    }
}
/*Bill table:
BillID(Primary Key)
UserID(Foreign Key referencing User table)
TotalAmount
BillingDate
Other bill details*/