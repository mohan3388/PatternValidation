using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class LastName
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[A-Za-z]{2,}$"; 

        public bool LNameValidation(string lname)
        {
            return Regex.IsMatch(lname, REGEX_PATTERN);
        }
    }
}
