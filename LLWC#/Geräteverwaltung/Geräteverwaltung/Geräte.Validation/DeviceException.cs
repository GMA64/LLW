using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geräte.Validation
{
    public enum ErrorCode
    {
        SHORT,
        LONG,
        EMPTY
    }

    public class DeviceException : Exception
    {
        public ErrorCode Errorname { get; set; }

        public DeviceException(ErrorCode error)
        {
            Errorname = error;
        }

        public DeviceException(ErrorCode error, string message) : base(message)
        {
            Errorname = error;
        }

        public string ErrorMessage()
        {
            switch (Errorname)
            {
                case ErrorCode.SHORT:
                    return "Value is to short" + base.Message;
                case ErrorCode.LONG:
                    return "Value is to long" + base.Message;
                case ErrorCode.EMPTY:
                    return "Value is empty" + base.Message;
                default:
                    return string.Empty;
            }
        }

    }
}
