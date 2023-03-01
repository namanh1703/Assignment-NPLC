namespace DepartmentManage
{
    public class DepartmentManage
    {
        /// <summary>
        /// Main method for the Department Management program. Displays a menu of options for the user to choose from, 
        /// including inputting employees, displaying employees, classifying employees, searching for employees, and generating reports.
        /// </summary>
        private static void Main()
        {
            // Create a list to store all the departments
            List<Department> listOfDepartment = new List<Department>();

            //Test case
            // Create a list to store employees for a department and add an HourlyEmployee to the list
            List<Employee> listOfEmployee = new List<Employee> { new HourlyEmployee("3", "Nam", "Anh", "17/03/2001", "0585877172", "Anhdhnhe153381@fpt.edu.vn", 12, 15) };
            // Add the department with its employees to the list of departments
            listOfDepartment.Add(new Department("it", listOfEmployee));

            // Repeat the process for other departments and employees
            List<Employee> listOfEmployee1 = new List<Employee> { new HourlyEmployee("2", "Viet", "Anh", "02/01/2003", "0123456789", "VietAnh@gmail.com", 122, 151) };
            listOfDepartment.Add(new Department("c#", listOfEmployee1));

            List<Employee> listOfEmployee2 = new List<Employee> { new HourlyEmployee("1", "Nam", "Ha", "12/11/1995", "07642154", "NamHa@gmail.com", 122, 135) };
            listOfDepartment.Add(new Department("java", listOfEmployee2));

            //Create a list to store employees for a department and add an SalariedEmployee to the list
            List<Employee> listOfEmployee3 = new List<Employee> { new SalariedEmployee("8", "Hoang", "Ha", "06/04/2002", "0231236783", "HoangHa@gmail.com", 34, 123, 12000000) };
            // Add the department with its employees to the list of departments
            listOfDepartment.Add(new Department("php", listOfEmployee3));

            // Repeat the process for other departments and employees
            List<Employee> listOfEmployee4 = new List<Employee> { new SalariedEmployee("6", "Viet", "Dung", "12/05/1996", "0125631672", "VietDung@gmail.com", 34, 456, 15000000) };
            listOfDepartment.Add(new Department("css", listOfEmployee4));

            List<Employee> listOfEmployee5 = new List<Employee> { new SalariedEmployee("3", "Hao", "Nam", "05/07/1995", "0234891273", "HaoNam@gmail.com", 123, 45, 17000000) };
            listOfDepartment.Add(new Department("html", listOfEmployee5));

            //Display the menu on the screen
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Department Manage");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Input Employee                                **");
                Console.WriteLine("**  2. Display Employees                             **");
                Console.WriteLine("**  3. Classify employees.                           **");
                Console.WriteLine("**  4. Employee Search.                              **");
                Console.WriteLine("**  5. Report                                        **");
                Console.WriteLine("**  0. Exit                                          **");
                Console.WriteLine("*******************************************************");
                Console.Write("Enter Key: ");
                // Try to parse the input from the user as an integer
                if (!int.TryParse(Console.ReadLine(), out var key))
                {
                    Console.Clear();
                    // If the input is not an integer, clear the console and start over
                    continue;
                }
                // Switch based on the key entered by the user
                switch (key)
                {
                    case 1:
                        // Call the InputEmployee method and pass it the listOfDepartment
                        InputEmployee(listOfDepartment);
                        Console.Read();
                        break;
                    case 2:
                        // Call the DisplayEmployee method and pass it the listOfDepartment
                        DisplayEmployee(listOfDepartment);
                        Console.Read();
                        break;
                    case 3:
                        // Call the ClassifyEmployees method and pass it the listOfDepartment
                        ClassifyEmployees(listOfDepartment);
                        break;
                    case 4:
                        // Call the FindEmployees method and pass it the listOfDepartment
                        FindEmployees(listOfDepartment);
                        break;
                    case 5:
                        // Call the Report method and pass it the listOfDepartment
                        Report(listOfDepartment);
                        Console.Read();
                        break;
                    case 0:
                        //If the user selects 0, they will exit the program
                        Console.WriteLine("\nYou exited the program!");
                        return;
                    default:
                        Console.WriteLine("\nPlease enter the correct Key: ");
                        break;
                }
            }
        }

        /// <summary>
        /// InputEmployee function is used to input Employee information into the system.
        /// The function presents a menu to the user with two options:
        /// 1. Enter Salaried Employee
        /// 2. Enter Hourly Employee
        /// 0. Return
        /// If the user selects option 1 or 2, the function calls the `InputSalariedEmployee` or `InputHourlyEmployee` function respectively to input the details of the employee.
        /// Then, it calls the `EnterDepartment` function to assign the entered employee to a department.
        /// </summary>
        /// <param name="listOfDepartment">List of Departments in the system.</param>
        private static void InputEmployee(List<Department> listOfDepartment)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tInput Employee");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Enter Salaried Employee                       **");
                Console.WriteLine("**  2. Enter Hourly Employee                         **");
                Console.WriteLine("**  0. Return                                        **");
                Console.WriteLine("*******************************************************");
                // Try to parse the input from the user as an integer
                if (!int.TryParse(Console.ReadLine(), out var key))
                {
                    Console.Clear();
                    // If the input is not an integer, clear the console and start over
                    continue;
                }
                // Switch based on the key entered by the user
                switch (key)
                {
                    case 1:
                        //Enter Salaried Employee
                        SalariedEmployee inputSalariedEmployee = InputSalariedEmployee();
                        //Enter Department Employee
                        EnterDepartment(listOfDepartment, inputSalariedEmployee);
                        break;
                    case 2:
                        //Enter Hourty Employee
                        HourlyEmployee inputHourlyEmployee = InputHourlyEmployee();
                        //Enter Department Employee
                        EnterDepartment(listOfDepartment, inputHourlyEmployee);
                        break;
                    case 0:
                        return;
                }
            }
        }
        /// <summary>
        /// This method inputs data for a salaried employee
        /// </summary>
        /// <returns>Return the filled SalariedEmployee object</returns>
        private static SalariedEmployee InputSalariedEmployee()
        {
            // Create a new SalariedEmployee object
            SalariedEmployee inputEmployee = new SalariedEmployee();
            // Input basic information for the employee
            Console.WriteLine("Enter Employee SSN: ");
            inputEmployee.Ssn = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee First Name: ");
            inputEmployee.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Last Name: ");
            inputEmployee.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Brith Day: ");
            inputEmployee.BirthDay = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Phone: ");
            inputEmployee.Phone = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Email: ");
            inputEmployee.Email = Convert.ToString(Console.ReadLine());

            // Input Commission Rate:
            string? stringinput;
            double inputCommissionRate;
            do
            {
                Console.WriteLine("Enter Commission Rate: ");
                stringinput = Console.ReadLine();
            }
            while (!double.TryParse(stringinput, out inputCommissionRate));
            inputEmployee.CommissionRate = inputCommissionRate;

            // Input Gross Sales:
            double inputGrossSales;
            do
            {
                Console.WriteLine("Enter Gross Sales: ");
                stringinput = Console.ReadLine();
            }
            while (!double.TryParse(stringinput, out inputGrossSales));
            inputEmployee.GrossSales = inputGrossSales;

            // Input Basic Salary:
            double inputBasicSalary;
            do
            {
                Console.WriteLine("Enter Basic Salary: ");
                stringinput = Console.ReadLine();
            }
            while (!double.TryParse(stringinput, out inputBasicSalary));
            inputEmployee.BasicSalary = inputBasicSalary;

            // Return the filled SalariedEmployee object
            return inputEmployee;
        }

        /// <summary>
        /// This method inputs data for a hourty employee
        /// </summary>
        /// <returns>Return the filled HourlyEmployee object</returns>
        private static HourlyEmployee InputHourlyEmployee()
        {
            // Create a new HourlyEmployee object
            HourlyEmployee inputEmployee = new HourlyEmployee();
            // Input basic information for the employee
            Console.WriteLine("Enter Employee SSN: ");
            inputEmployee.Ssn = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Frist Name: ");
            inputEmployee.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Last Name: ");
            inputEmployee.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Brith Day: ");
            inputEmployee.BirthDay = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Phone: ");
            inputEmployee.Phone = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Email: ");
            inputEmployee.Email = Convert.ToString(Console.ReadLine());

            // Input Wage:
            string? stringinput;
            double inputWage;
            do
            {
                Console.WriteLine("Enter Wage: ");
                stringinput = Console.ReadLine();
            }
            while (!double.TryParse(stringinput, out inputWage));
            inputEmployee.Wage = inputWage;

            // Input Working Hours:
            double inputWorkingHours;
            do
            {
                Console.WriteLine("Enter Commission Rate: ");
                stringinput = Console.ReadLine();
            }
            while (!double.TryParse(stringinput, out inputWorkingHours));
            inputEmployee.WorkingHours = inputWorkingHours;

            // Return the filled HourlyEmployee object
            return inputEmployee;
        }


        /// <summary>
        /// This method is used to enter department information for a Salaried Employee and add the employee to the department.
        /// If the entered department name does not exist in the department list, the user is given the option to create a new
        /// department with the specified name.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments in the company.</param>
        /// <param name="inputSalariedEmployee">The Salaried Employee to be added to the department.</param>
        private static void EnterDepartment(List<Department> listOfDepartment, SalariedEmployee inputSalariedEmployee)
        {
            Console.WriteLine("Enter Employee Department: ");
            var stringinput = Convert.ToString(Console.ReadLine());

            // Check if the department name already exists
            if (stringinput != null && !FindDepartmentName(listOfDepartment, stringinput))
            {
                // If the department does not exist, prompt the user to create it
                Console.WriteLine("Employee Department does not exist !   \n Create Department {0} ?\n 1 : Yes \n 2 : No and Exit", stringinput);
                if (int.TryParse(Console.ReadLine(), out var key) && key == 1)
                {
                    // Create a new department and add the employee to it
                    Department newDepartment = new Department();
                    List<Employee> listEmployee = new List<Employee> { inputSalariedEmployee };
                    newDepartment.DepartmentName = stringinput;
                    newDepartment.ListOfEmployee = listEmployee;
                    listOfDepartment.Add(newDepartment);
                }
            }
            else
            {
                // If the department already exists, add the employee to it
                Department newDepartment = new Department();
                List<Employee> listEmployee = new List<Employee> { inputSalariedEmployee };
                newDepartment.DepartmentName = stringinput;
                newDepartment.ListOfEmployee = listEmployee;
                listOfDepartment.Add(newDepartment);
            }

            // Confirm that the salaried employee was entered successfully
            Console.WriteLine("Enter Salaried Employee successful ! ");
        }

        /// <summary>
        /// This method is used to enter department information for a Hourly Employee and add the employee to the department.
        /// If the entered department name does not exist in the department list, the user is given the option to create a new
        /// department with the specified name.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments in the company.</param>
        /// <param name="inputHourlyEmployee">The Salaried Employee to be added to the department.</param>
        private static void EnterDepartment(List<Department> listOfDepartment, HourlyEmployee inputHourlyEmployee)
        {
            Console.WriteLine("Enter Employee Department: ");
            var stringinput = Convert.ToString(Console.ReadLine());
            // Check if the department name does not exist, then create a new department
            if (!FindDepartmentName(listOfDepartment, stringinput))
            {
                Console.WriteLine("Employee Department does not exist !   \n Create Department {0} ?\n 1 : Yes \n Any key : No and Exit", stringinput);
                if (int.TryParse(Console.ReadLine(), out var key) && key == 1)
                {
                    // Create a new department object
                    var newDepartment = new Department();
                    // Create a list of employees with the input Hourly Employee
                    var listEmployee = new List<Employee> { inputHourlyEmployee };
                    // Assign the department name and list of employees to the new department object
                    newDepartment.DepartmentName = stringinput;
                    newDepartment.ListOfEmployee = listEmployee;
                    // Add the new department to the list of departments
                    listOfDepartment.Add(newDepartment);
                }
            }
            else
            {
                // Add the Hourly Employee to an existing department
                var newDepartment = new Department();
                var listEmployee = new List<Employee> { inputHourlyEmployee };
                newDepartment.DepartmentName = stringinput;
                newDepartment.ListOfEmployee = listEmployee;
                listOfDepartment.Add(newDepartment);
            }
            // Confirm that the hourly employee was entered successfully
            Console.WriteLine("Enter Hourly Employee successful ! ");
        }

        /// <summary>
        /// Searches for a department name in the list of departments.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments to search in.</param>
        /// <param name="name">The name of the department to search for.</param>
        /// <returns>True if the department name is found, false otherwise.</returns>
        private static bool FindDepartmentName(List<Department> listOfDepartment, string? name)
        {
            //Iterate through the list of departments to find if a department with the given name exists
            foreach (var department in listOfDepartment)
            {
                //If a department with the given name is found, return true
                if (department.DepartmentName == name)
                    return true;
            }

            //Return false if no department with the given name is found
            return false;
        }

        /// <summary>
        /// Displays all the employees in the departments.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments that contain the employees.</param>
        private static void DisplayEmployee(List<Department> listOfDepartment)
        {
            // Display the header
            Console.WriteLine("DepartmentName {0, 20} {1, 20} {2, 20} {3, 20} {4, 20} {5, 20}",
                          "SSN", "FirstName", "LastName", "BirthDay", "Phone", "Email");
            // Loop through all departments
            foreach (var department in listOfDepartment)         
            {
                // Loop through all employees of each department
                foreach (var employee in department.ListOfEmployee)    
                {
                    // Display each employee
                    Console.Write(department.DepartmentName);       
                    employee.Display(employee);
                }
            }
        }


        /// <summary>
        /// This function is used to classify employees based on their type (Salaried or Hourly).
        /// </summary>
        /// <param name="listOfDepartment">List of all departments.</param>
        private static void ClassifyEmployees(List<Department> listOfDepartment)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Classify Employees");
                Console.WriteLine("*************************MENU*****************************");
                Console.WriteLine("**  1. Classify Salaried Employee                       **");
                Console.WriteLine("**  2. Classify Hourly Employee                         **");
                Console.WriteLine("**  0. Return                                           **");
                Console.WriteLine("**********************************************************");
                if (!int.TryParse(Console.ReadLine(), out var key))
                {
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("DepartmentName {0, 25} {1, 25} {2, 25} {3, 25} {4, 25} {5, 25}",
                                  "SSN", "FirstName", "LastName", "BirthDay", "Phone", "Email");
                switch (key)
                {
                    case 1:
                        // Loop through all departments
                        foreach (var department in listOfDepartment)
                        {
                            // Loop through all employees of each department
                            // Check if the employee is a `SalariedEmployee` and display it
                            foreach (var employee in department.ListOfEmployee.Where(employee => employee.GetType() == new SalariedEmployee().GetType()))
                            {
                                Console.Write(department.DepartmentName + "  ");
                                employee.Display(employee);
                            }
                        }
                        Console.Read();
                        break;
                    case 2:
                        // Loop through all departments
                        foreach (var department in listOfDepartment)
                        {
                            // Loop through all employees of each department
                            // Check if the employee is a `HourlyEmployee` and display it
                            foreach (var employee in department.ListOfEmployee.Where(employee => employee.GetType() == new HourlyEmployee().GetType()))
                            {
                                Console.Write(department.DepartmentName + "  ");
                                employee.Display(employee);
                            }
                        }
                        Console.Read();
                        break;
                    case 0:
                        return;
                }
            }
        }


        /// <summary>
        /// Method for finding employees based on either their name or the department they work in.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments to search for employees in.</param>
        private static void FindEmployees(List<Department> listOfDepartment)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Classify Employees");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Search employees by name department           **");
                Console.WriteLine("**  2. Search employees by last name Employee        **");
                Console.WriteLine("**  0. Return                                        **");
                Console.WriteLine("*******************************************************");

                // Read the user input for the menu option and parse it to an integer
                if (!int.TryParse(Console.ReadLine(), out var key))
                {
                    Console.Clear();
                    // If the input is not an integer, clear the console and repeat the menu
                    continue;   
                }

                // Take different actions based on the menu option selected
                switch (key)
                {
                    case 1:
                        // Search for employees by department name
                        Console.Write("Enter Department Name: ");
                        var inputname = Console.ReadLine();
                        Console.WriteLine("DepartmentName {0, 20} {1, 20} {2, 20} {3, 20} {4, 20} {5, 20}",
                                      "SSN", "FirstName", "LastName", "BirthDay", "Phone", "Email");
                        foreach (var department in listOfDepartment.Where(department => department.DepartmentName != null && department.DepartmentName.Equals(inputname)))
                        {
                            // Display the details of each salaried employee in the selected department
                            foreach (var employee in department.ListOfEmployee.Where(employee => employee.GetType() == new SalariedEmployee().GetType()))
                            {
                                Console.Write(department.DepartmentName + "  ");
                                employee.Display(employee);
                            }

                            // Display the details of each hourly employee in the selected department
                            foreach (var employee in department.ListOfEmployee.Where(employee => employee.GetType() == new HourlyEmployee().GetType()))
                            {
                                Console.Write(department.DepartmentName + "  ");
                                employee.Display(employee);
                            }
                        }
                        Console.Read();
                        break;
                    case 2:
                        // Search for employees by employee name
                        Console.Write("Enter Employee Name: ");
                        var inputnameEmployee = Console.ReadLine();
                        foreach (var department in listOfDepartment)
                        {
                            // Display the details of each employee with the selected name
                            foreach (var employee in department.ListOfEmployee.Where(employee => employee.LastName != null && employee.LastName.Equals(inputnameEmployee)))
                            {
                                Console.Write(department.DepartmentName + "  ");
                                employee.Display(employee);
                            }
                        }
                        Console.Read();
                        break;
                    case 0:
                        return;
                }
            }
        }

        /// <summary>
        /// This function is used to generate a report of departments and the number of employees in each department.
        /// </summary>
        /// <param name="listOfDepartment">The list of departments to be reported.</param>
        private static void Report(List<Department> listOfDepartment)
        {
            Console.WriteLine("Department Name \t   Sum of Employee");
            // Loop through the list of departments
            foreach (var department in listOfDepartment) 
            {
                // Print the department name and the number of employees in each department
                Console.WriteLine("" + "{0 ,30}  {1 ,30}", department.DepartmentName, department.ListOfEmployee.Count());
            }
        }

    }
}
