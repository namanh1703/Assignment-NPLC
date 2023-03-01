namespace DepartmentManage
{
    /// <summary>
    /// A class to represent a Department in an organization.
    /// </summary>

    public class Department
    {
        // Property for DepartmentName
        public string? DepartmentName { get; set; }

        // Property for the list of employees in a department
        public List<Employee> ListOfEmployee { get; set; }

        // Constructor to initialize a department with a list of employees
        public Department(List<Employee> listOfEmployee)
        {
            this.ListOfEmployee = listOfEmployee;
        }

        // Constructor to initialize a department with a name and a list of employees
        public Department(string? departmentName, List<Employee> listOfEmployee)
        {
            DepartmentName = departmentName;
            this.ListOfEmployee = listOfEmployee;
            ListOfEmployee = listOfEmployee;
        }

        // Default constructor to initialize an empty department
        public Department()
        {
        }
    }
}

