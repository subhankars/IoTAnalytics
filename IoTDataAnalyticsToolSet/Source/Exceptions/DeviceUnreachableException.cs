﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2CodingLab.SensorTag.Exceptions
{
    /// <summary>
    /// Thrown when the deviceservice could be retrieved, but the actual communication with the device failed.
    /// </summary>
    public class DeviceUnreachableException : Exception
    {
        internal const string DEFAULT_UNREACHABLE_MESSAGE = "Could not reach the device. Make sure it's in range, it's able to establish a connection and send and receive data.";

        public DeviceUnreachableException()
            : base()
        {

        }

        public DeviceUnreachableException(string message)
            : base(message)
        {

        }

        public DeviceUnreachableException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
