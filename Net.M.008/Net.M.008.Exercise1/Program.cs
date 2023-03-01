using System;
using System.Collections.Generic;
using System.Globalization;

namespace Net.M.A008.Exercise1
{
    class Program
    {
        /// <summary>
        /// Write code to check string is correct date format dd/MM/yyyy. If yes, convert string to datetime value then get
        /// the first day of the month.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Input date string in dd/MM/yyyy format
            Console.WriteLine("Enter date time in dd/MM/yyyy format: ");
            string dateString = Convert.ToString(Console.ReadLine());

            // Variable to store the converted date
            DateTime date;
            //Check input string for correct format
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out date))
            {
                //If the format is correct, get the first day of the month and output the result
                Console.WriteLine("First day of the month: " +
                                  new DateTime(date.Year, date.Month, 1).ToString("dd/MM/yyyy"));
            }
            else
            {
                //If not in the correct format, output error message
                Console.WriteLine("Incorrect format.");
            }
        }
    }
}