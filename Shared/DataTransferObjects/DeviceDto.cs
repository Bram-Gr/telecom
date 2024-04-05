using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shared.DataTransferObjects
{
    public class DeviceDto
    {
        public Guid Id { get; init; }
        public string? PhoneNumber { get; init; }
        public Guid UserID { get; init; }
        public Guid PlanID { get; init; }
        public string? OtherDeviceDetails { get; init; }
    }
}
