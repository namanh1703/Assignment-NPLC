using System.Globalization;
using System.Xml.Linq;

namespace DepartmentManage
{
    // <summary>
    /// This is a class representing an Employee which implements the IPayable interface.
    /// </summary>
    public class Employee : IPayable
    {
        /// <summary>
        /// Implemented method from the IPayable interface to get the payment amount.
        /// </summary>
        /// <returns>A double value representing the payment amount.</returns>
        public double GetPaymentAmount()
        {
            return 1.5;
        }
        //The Social Security Number of the employee.
        public string? Ssn { get; set; }

        //The first name of the employee.
        public string? FirstName { get; set; }

        //The last name of the employee.
        public string? LastName { get; set; }

        
        private string? birthDay;
        //The birth date of the employee.
        public string? BirthDay
        {
            get { return birthDay; }
            set
            {
                DateTime valuedate;
                string? inputstr = value;

                // loop to parse the date until it is in the correct format
                while (!DateTime.TryParseExact(inputstr, "dd/MM/yyyy", new CultureInfo("en-US"),
                                               DateTimeStyles.None, out valuedate))
                {
                    Console.WriteLine("Error Day - (DD/MM/YYYY)\nEnter Employee Brith Day: ");
                    inputstr = Console.ReadLine();
                }


                birthDay = valuedate.ToString("dd/MM/yyyy");

            }
        }

        private string? phone;
        //The phone number of the employee.
        public string? Phone
        {
            get { return phone; }
            set
            {
                int inputphone;
                // loop to parse the phone number until it is in the correct format
                while (!int.TryParse(value, out inputphone) || value.Length < 7)
                {
                    Console.WriteLine("Error1 \nEnter Employee Phone again: ");
                    value = Console.ReadLine();
                }
                phone = inputphone.ToString();
            }

        }

        private string? email;
        //The email of the employee.
        public string? Email
        {
            get { return email; }
            set
            {
                // loop to parse the email until it is in the correct format
                while (true)
                {
                    var trimmedEmail = value?.Trim();

                    if (trimmedEmail != null && trimmedEmail.EndsWith("."))
                    {
                        Console.WriteLine("Enter Employee Email again: ");
                        value = Convert.ToString(Console.ReadLine());
                        continue;
                    }
                    try
                    {
                        if (value != null)
                        {
                            var address = new System.Net.Mail.MailAddress(value);
                            if (address.Address == trimmedEmail)
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Enter Employee Email" +
                            " again: ");
                        value = Convert.ToString(Console.ReadLine());
                    }
                }
                email = value;
            }
        }

        // Default constructor to initialize an empty employee
        public Employee() { }

        // Constructor to initialize the properties
        public Employee(string? ssn, string? firstName, string? lastName, string? birthDay, string? phone, string? email)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
        }
        /// <summary>
        /// Returns the Social Security Number (SSN) of the employee
        /// </summary>
        /// <returns>The SSN of the employee</returns>
        public string? GetSsn()
        {
            return Ssn;
        }

        /// <summary>
        /// Sets the Social Security Number (SSN) of the employee
        /// </summary>
        /// <param name="ssn">The SSN of the employee</param>
        public void SetSsn(string? ssn)
        {
            Ssn = ssn;
        }

        /// <summary>
        /// Displays the information of the employee
        /// </summary>
        /// <param name="ep">The instance of the employee</param>
        public void Display(Employee ep)
        {
            Console.WriteLine("\t\t{0, 20} {1, 20} {2, 20} {3, 20} {4, 20} \t {5, 20}",
                       ep.Ssn, ep.FirstName, ep.LastName, ep.birthDay, ep.phone, ep.email);
        }

    }
}
