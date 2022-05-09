using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegixValidationDemo
{
    public class PinCodeValidation
    {
        public const string PINCODE_REGEX = "^[0-9]{6}$";
        //public const string EMAIL_REGEX = "^[a-z]$";
        //public const string EMAIL_REGEX = "^[a-z]+[@]{1}[a-z]$";
        //public const string EMAIL_REGEX = "^[a-z]+[@][a-z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public void Validate(string pincode)
        {
            if (Regex.IsMatch(pincode, PINCODE_REGEX))
            {
                Console.WriteLine("Pincode Matches");
            }
            else
            {
                Console.WriteLine("Verify Pincode Again");
            }
        }
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email,EMAIL_REGEX))
            {
                Console.WriteLine("Email Matches");
            }
            else
            {
                Console.WriteLine("Verify Email Again");
            }
        }
    }
}
