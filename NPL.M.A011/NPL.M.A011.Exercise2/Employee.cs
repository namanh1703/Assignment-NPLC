using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A011.Exercise2
{
    /// <summary>
    /// Create a class called Employee that includes three pieces of information
    /// </summary>
    class Employee
    {
        // Instance variables for an Employee
        public string FirstName { get; set; }       // First name of the Employee
        public string LastName { get; set; }        // Last name of the Employee
        private double monthlySalary;               // Monthly salary of the Employee
        
        // Monthly salary property with a get and set method
        public double MonthlySalary
        {
            get { return monthlySalary; }
            set
            {
                // Set the monthly salary to 0 if it's not positive
                if (value > 0)
                    monthlySalary = value;
                else
                    monthlySalary = 0;
            }
        }
        /// <summary>
        /// Method to return the description of the employee
        /// </summary>
        /// <returns>Return the information about the employee as a string</returns>
        public string GetEmployeeInformation()
        {
            // Return the book as a string
            return "FirstName: " + FirstName + "\n" +
                   "LastName: " + LastName + "\n" +
                   "MonthlySalary: " + MonthlySalary;
        }
    }
}
