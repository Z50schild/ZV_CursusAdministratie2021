using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ZV_CursusAdministratie.Exceptions
{
    public class FileToObjectException: Exception
    {
        public FileToObjectException() : base() { }

        public FileToObjectException(string message) : base(message) { }

        public FileToObjectException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}