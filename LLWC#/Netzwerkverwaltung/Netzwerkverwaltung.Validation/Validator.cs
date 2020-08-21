using Netzwerkverwaltung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Validation
{
    public static class Validator
    {
        private const int NAME_MIN_LENGTH = 2;
        private const int NAME_MAX_LENGTH = 20;

        private const int IP_MIN_LENGTH = 7;
        private const int IP_MAX_LENGTH = 15;

        private const int DEVICE_MIN_LENGTH = 5;
        private const int DEVICE_MAX_LENGTH = 40;

        private const int DESCRIPTION_MIN_LENGTH = 2;
        private const int DESCRIPTION_MAX_LENGTH = 100;

        public static void MakeValidation(this NetworkData data)
        {
            data.CheckName().CheckIPAddress().CheckGerätetyp().CheckKurzbeschreibung();
        }

        public static NetworkData CheckName(this NetworkData data)
        {
            if (string.IsNullOrEmpty(data.Name))
                throw new NetzwerkException(Errorcode.EMPTY, nameof(data.Name));

            if (data.Name.Length < NAME_MIN_LENGTH)
                throw new NetzwerkException(Errorcode.SHORT, nameof(data.Name));

            if (data.Name.Length > NAME_MAX_LENGTH)
                throw new NetzwerkException(Errorcode.LONG, nameof(data.Name));

            return data;
        }
        public static NetworkData CheckIPAddress(this NetworkData data)
        {
            if (string.IsNullOrEmpty(data.IpAdresse))
                throw new NetzwerkException(Errorcode.EMPTY, nameof(data.IpAdresse));

            if (data.IpAdresse.Length < IP_MIN_LENGTH)
                throw new NetzwerkException(Errorcode.SHORT, nameof(data.IpAdresse));

            if (data.IpAdresse.Length > IP_MAX_LENGTH)
                throw new NetzwerkException(Errorcode.LONG, nameof(data.IpAdresse));

            return data;
        }
        public static NetworkData CheckGerätetyp(this NetworkData data)
        {
            if (string.IsNullOrEmpty(data.Gerätetype))
                throw new NetzwerkException(Errorcode.EMPTY, nameof(data.Gerätetype));

            if (data.Gerätetype.Length < DEVICE_MIN_LENGTH)
                throw new NetzwerkException(Errorcode.SHORT, nameof(data.Gerätetype));

            if (data.Gerätetype.Length > DEVICE_MAX_LENGTH)
                throw new NetzwerkException(Errorcode.LONG, nameof(data.Gerätetype));

            return data;
        }
        public static NetworkData CheckKurzbeschreibung(this NetworkData data)
        {
            if (string.IsNullOrEmpty(data.Kurzbeschreibung))
                throw new NetzwerkException(Errorcode.EMPTY, nameof(data.Kurzbeschreibung));

            if (data.Kurzbeschreibung.Length < DESCRIPTION_MIN_LENGTH)
                throw new NetzwerkException(Errorcode.SHORT, nameof(data.Kurzbeschreibung));

            if (data.Kurzbeschreibung.Length > DESCRIPTION_MAX_LENGTH)
                throw new NetzwerkException(Errorcode.LONG, nameof(data.Kurzbeschreibung));

            return data;
        }

    }
}
