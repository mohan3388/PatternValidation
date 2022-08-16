using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Mobile
    {
        public static string REGEX_PATTERN = "^[91]{2}[' ']{1}[7-9]{2}[1-9]{8}$";

        public bool MobileValidation(string Mname)
        {
            return Regex.IsMatch(Mname, REGEX_PATTERN);
        }
    }
}
