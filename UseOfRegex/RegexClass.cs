using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseOfRegex
{
    internal class RegexClass
    {
        public Regex FirstName = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");
        public Regex LastName = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");
        public Regex Email = new Regex(@"^[a-z A-Z 0-9 .+_-]+@[a-z A-Z 0-9 -.]+[.][a-z A-Z 0-9 -]{2,}$");
        public Regex MobileNumber = new Regex(@"[0-9]{1,2}\s[0-9]{10}");
        public Regex PasswordMin8Char = new Regex(@"[A-Z a-z 0-9]{8,}");
        public Regex PasswordMin8Char2 = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");
        public Regex PasswordMin8Char3 = new Regex(@"(?=.*[0-9])[A-Za-z0-9]{8,}");
        public Regex PasswordMin8Char4 = new Regex(@"(?=.*[#?!@$%^&*-])[A-Za-z0-9].{8,}");

    }
}


