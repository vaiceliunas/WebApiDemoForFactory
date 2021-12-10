using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models.Constants
{
    public static class ErrorMessages
    {
        public static string InvalidAddressErrorMessage => "Invalid person address";
        public static string IdSetErrorMessage => "Id cannot be set on this operation";
    }

    public static class PropertyNames
    {
        public static string General => "General";
        public static string IdProperty => "Id";
        public static string PersonAddressProperty => "Address";
    }
}
