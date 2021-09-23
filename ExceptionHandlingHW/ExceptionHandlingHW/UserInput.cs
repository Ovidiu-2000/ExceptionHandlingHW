using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandlingHW
{
    class UserInput
    {
        public string ValidateEmail()
        {
            bool flag = new bool();
            string regexEmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regexEmail = new Regex(regexEmailPattern);
            string email = Console.ReadLine();
            while (!flag)
            {
                try
                {
                    if (regexEmail.IsMatch(email))
                    {
                        flag = true;
                        Console.WriteLine("The email adress is valid");
                        return email;
                    }
                    else
                    {
                        throw new FormatException(string.Format("The email '{0}' is invalid, please write a valid email", email));
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                    email = Console.ReadLine();
                }
            }
            return email;
        }
        public string ValidatePhoneNumber()
        {
            bool flag = new bool();
            string regexPhoneNumberPattern = @"^[0-9]*$";
            Regex regexPhoneNumber = new Regex(regexPhoneNumberPattern);
            string phoneNumber = Console.ReadLine();

            while (!flag)
            {
                try
                {
                    if (regexPhoneNumber.IsMatch(phoneNumber) && phoneNumber.Length == 9)
                    {
                        flag = true;
                        Console.WriteLine("The phone number is valid");
                        return phoneNumber;
                    }
                    else
                    {
                        throw new FormatException(string.Format("The phone number '{0}' is invalid, please write a valid phone number", phoneNumber));
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                    phoneNumber = Console.ReadLine();
                }
            }
            return phoneNumber;
        }

        public string ValidateDateOfBirth()
        {
            bool flag = new bool();
            string regexDateOfBirthPattern = @"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
            Regex regexDateOfBirth = new Regex(regexDateOfBirthPattern);
            string dateOfBirth = Console.ReadLine();

            while (!flag)
            {
                try
                {
                    if (regexDateOfBirth.IsMatch(dateOfBirth))
                    {
                        flag = true;
                        Console.WriteLine("The date of birth is valid");
                        return dateOfBirth;
                    }
                    else
                    {
                        throw new FormatException(string.Format("The date of birth '{0}' is invalid, please write a valid date of birth", dateOfBirth));
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                    dateOfBirth = Console.ReadLine();
                }
            }
            return dateOfBirth;
        }

        public string ValidateZipCode()
        {
            bool flag = new bool();
            string regexZipCodePattern = @"^[0-9]*$";
            Regex regexZipCode = new Regex(regexZipCodePattern);
            string zipCode = Console.ReadLine();
            while (!flag)
            {
                try
                {
                    if (regexZipCode.IsMatch(zipCode) && zipCode.Length == 5)
                    {
                        flag = true;
                        Console.WriteLine("The zip code is valid");
                        return zipCode;
                    }
                    else
                    {
                        throw new FormatException(string.Format("The zip code '{0}' is invalid, please write a valid zip code", zipCode));
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                    zipCode = Console.ReadLine();
                }
            }
            return zipCode;
        }

        public string ValidateWebsite()
        {
            bool flag = new bool();
            string regexWebsitePattern = @"^((https?|ftp|smtp):\/\/)?(www.)?[a-z0-9]+\.[a-z]+(\/[a-zA-Z0-9#]+\/?)*$";
            Regex regexWebsite = new Regex(regexWebsitePattern);
            string website = Console.ReadLine();
            while (!flag)
            {
                try
                {
                    if (regexWebsite.IsMatch(website))
                    {
                        flag = true;
                        Console.WriteLine("The website is valid");
                        return website;
                    }
                    else
                    {
                        throw new FormatException(string.Format("The website '{0}' is invalid, please write a valid website", website));
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                    website = Console.ReadLine();
                }
            }
            return website;
        }
    }
}
