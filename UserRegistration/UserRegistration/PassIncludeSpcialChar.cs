using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class PassIncludeSpcialChar
    {
        public static string REGEX_PATTERN = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}[@!%^&*'#]{1}$";

        public bool PassIncludeOneSpecialChar(string Pass)
        {
            return Regex.IsMatch(Pass, REGEX_PATTERN);
        }
    }
}
