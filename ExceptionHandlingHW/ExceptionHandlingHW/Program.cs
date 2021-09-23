using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ExceptionHandlingHW
{
    class Program
    {
        static UserInput validUserInput = new UserInput();       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid Email:");
            string email = validUserInput.ValidateEmail();

            Console.WriteLine("Enter a valid phone number(9 digits):");
            string phoneNumber = validUserInput.ValidatePhoneNumber();

            Console.WriteLine("Enter a valid date of birth(format YYYY-MM-DD):");
            string dateOfBirth = validUserInput.ValidateDateOfBirth();

            Console.WriteLine("Enter a valid zip code(5 digits):");
            string zipCode = validUserInput.ValidateZipCode();

            Console.WriteLine("Enter a valid website code:");
            string website = validUserInput.ValidateWebsite();

            Console.WriteLine("Your input is:");
            Console.WriteLine("Email : {0}", email);
            Console.WriteLine("Phone number : {0}", phoneNumber);
            Console.WriteLine("Date of birth : {0}", dateOfBirth);
            Console.WriteLine("Zip code : {0}", zipCode);
            Console.WriteLine("Website : {0}", website);
        }
    }
}