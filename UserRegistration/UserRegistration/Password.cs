using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password
    {
        public static string REGEX_PATTERN = "^[0-9]{8}$";

        public bool PassValidation(string Mname)
        {
            return Regex.IsMatch(Mname, REGEX_PATTERN);
        }
    }
}
