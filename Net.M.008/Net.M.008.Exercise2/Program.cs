namespace Net.M.A008.Exercise2
{
    class Program
    {
        /// <summary>
        /// Write code to count number of working day in a month
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Enter the month and year in MMM/yyyy format
            Console.WriteLine("Enter the month and year in the format MMM/yyyy:");
            string input = Console.ReadLine();
            DateTime date = Convert.ToDateTime(input);

            int workingDays = 0;
            // Get the number of days in the month
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            // Loop through all the days in the month
            for (int i = 1; i <= daysInMonth; i++)
            {
                // Get the current day
                DateTime currentDay = new DateTime(date.Year, date.Month, i);
                // Check if the current day is not a Saturday or Sunday
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }
            // Output the result
            Console.WriteLine("Number of working days in " + input + ": " + workingDays);
        }
    }
}