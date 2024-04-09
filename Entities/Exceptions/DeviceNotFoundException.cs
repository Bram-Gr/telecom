using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceNotFoundException: Exception
    {
        public DeviceNotFoundException(Guid deviceId) 
            : base($"The device with the id: {deviceId} cannot be found")
        {
        }
    }
}
