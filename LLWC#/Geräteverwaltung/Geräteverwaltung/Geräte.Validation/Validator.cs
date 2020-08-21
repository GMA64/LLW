using Geräte.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Geräte.Validation
{
    public static class Validator
    {

        public static void MakeValidation(this Device data)
        {
            data.CheckDeviceName().CheckDeviceType().CheckManufacturere();
        }

        public static Device CheckDeviceName(this Device data)
        {
            if (string.IsNullOrEmpty(data.DeviceName))
                throw new DeviceException(ErrorCode.EMPTY, nameof(data.DeviceName));

            if (data.DeviceName.Length < 2)
                throw new DeviceException(ErrorCode.SHORT, nameof(data.DeviceName));

            if (data.DeviceName.Length > 50)
                throw new DeviceException(ErrorCode.LONG, nameof(data.DeviceName));

            return data;
        }

        public static Device CheckDeviceType(this Device data)
        {
            if (string.IsNullOrEmpty(data.DeviceType))
                throw new DeviceException(ErrorCode.EMPTY, nameof(data.DeviceType));

            if (data.DeviceType.Length < 2)
                throw new DeviceException(ErrorCode.SHORT, nameof(data.DeviceType));

            if (data.DeviceType.Length > 50)
                throw new DeviceException(ErrorCode.LONG, nameof(data.DeviceType));

            return data;
        }

        public static Device CheckManufacturere(this Device data)
        {
            if (string.IsNullOrEmpty(data.Manufacturere))
                throw new DeviceException(ErrorCode.EMPTY, nameof(data.Manufacturere));

            if (data.Manufacturere.Length < 2)
                throw new DeviceException(ErrorCode.SHORT, nameof(data.Manufacturere));

            if (data.Manufacturere.Length > 50)
                throw new DeviceException(ErrorCode.LONG, nameof(data.Manufacturere));

            return data;
        }
    }
}
