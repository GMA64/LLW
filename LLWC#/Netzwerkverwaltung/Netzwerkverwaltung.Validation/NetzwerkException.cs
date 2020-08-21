using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Validation
{
    public enum Errorcode
    {
        SHORT,
        LONG,
        EMPTY
    }

    public class NetzwerkException : Exception
    {
        public NetzwerkException(Errorcode errorcode)
        {
            this.ErrorName = errorcode;
        }

        public NetzwerkException(Errorcode errorcode, string message) : base(message)
        {
            this.ErrorName = errorcode;
        }


        public Errorcode ErrorName { get; set; }

        public string ErrorMessage()
        {
            switch (ErrorName)
            {
                case Errorcode.SHORT:
                    return $"Value is to short {base.Message}";
                case Errorcode.LONG:
                    return $"Value is to long {base.Message}";
                case Errorcode.EMPTY:
                    return $"Value is empty {base.Message}";
                default:
                    return string.Empty;
            }
        }
    }
}
