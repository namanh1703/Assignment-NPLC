namespace NPL.M.A011.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            Employee e = new Employee()
            {
                FirstName = "Nam",
                LastName = "Anh",
                MonthlySalary = 120000
            };
            Employee e1 = new Employee()
            {
                FirstName = "Anh",
                LastName = "Nam",
            };

            //Print out the results
            Console.WriteLine(e.GetEmployeeInformation());
            Console.WriteLine("________________________");
            Console.WriteLine(e1.GetEmployeeInformation());
        }
    }
}