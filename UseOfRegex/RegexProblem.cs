using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UseOfRegex
{
    internal class RegexProblem
    {
       List<RegexClass> regexes = new List<RegexClass>();
        
        public RegexProblem()
        {
            RegexClass regexClass = new RegexClass();   
            
            regexes.Add(regexClass);
        }


        public void CheckFirstName(string fName)   
        {
            Console.WriteLine("first name is : " + fName);
            if (regexes.Any(x=> x.FirstName.IsMatch(fName)))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
            Console.WriteLine();
        }
        public void CheckLastName(string lName)    ///UC2
        {
            Console.WriteLine("last name is : " + lName);
            if (regexes.Any(x => x.LastName.IsMatch(lName)))
            {
                Console.WriteLine("Valid Last name");
            }
            else
            {
                Console.WriteLine("Invalid Last name");
            }
            Console.WriteLine();
        }

        public void CheckEmail(string email)    //UC3
        {
            Console.WriteLine("Email Id is : " + email);
            if (regexes.Any(x => x.Email.IsMatch(email)))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id");
            }
            Console.WriteLine();
        }
        public void CheckMobilNumber(string mobileNumber)
        {
            Console.WriteLine("Mobile number is : " + mobileNumber);
            if (regexes.Any(x => x.MobileNumber.IsMatch(mobileNumber)))
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();
        }
        public void CheckPassmin8Char(string pass)
        {
            Console.WriteLine("Password  is : " + pass);
            if (regexes.Any(x => x.PasswordMin8Char.IsMatch(pass)))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
            Console.WriteLine();
        }
        public void CheckPass8CharWithUpperCase(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (regexes.Any(x => x.PasswordMin8Char2.IsMatch(pass)))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
            Console.WriteLine();
        }
        public void CheckPass8CharWithNumber(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (regexes.Any(x => x.PasswordMin8Char3.IsMatch(pass)))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
            Console.WriteLine();
        }

        public void CheckPass8CharWithSpecialChar(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (regexes.Any(x => x.PasswordMin8Char4.IsMatch(pass)))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
            Console.WriteLine();
        }
    }
}
