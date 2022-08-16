using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class PassIncludeUppercase
    {
        public static string REGEX_PATTERN = "^[A-Z]{1,}[a-z]{7,}$";

        public bool PassIncludeOneUppercase(string Pass)
        {
            return Regex.IsMatch(Pass, REGEX_PATTERN);
        }
    }
}
