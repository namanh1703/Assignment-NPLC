using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EmailValidation
{
    /// <summary>
    /// Write code to validate email with above conditions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Input Email you want to check
            Console.Write("Enter your Email you want to check: ");
            String emailAddress = Console.ReadLine();

            //Check if the user has left a space or not entered anything
            while (string.IsNullOrWhiteSpace(emailAddress))
            {
                Console.WriteLine("Please enter any Email.");
                Console.WriteLine("Enter Email: ");
                emailAddress = Console.ReadLine();
            }
            Console.WriteLine($"Result: \n{emailAddress,-37} --> {(IsValidEmail(emailAddress) ? "Valid" : "Invalid")}");
        }
        /// <summary>
        /// Check if Email is in correct format
        /// </summary>
        /// <param name="email">check Email format entered by user</param>
        /// <returns>If the format is correct, return true, otherwise return false</returns>
        public static bool IsValidEmail(string email)
        {
            //Use the Regex function to check
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            //return true or false
            return regex.IsMatch(email);
        }
    }
}
