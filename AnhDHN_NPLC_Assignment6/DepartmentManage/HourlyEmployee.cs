namespace DepartmentManage
{
    /// <summary>
    /// The `SalariedEmployee` class represents a salaried employee, which is a type of `Employee`. 
    /// It contains properties for wage rate and number of working hours.
    /// </summary>
    class HourlyEmployee : Employee
    {
        // fields to store the employee's wage rate and working hours
        private readonly double wage;
        private readonly double workingHours;

        // property to get or set the employee's wage rate
        public double Wage { get; set; }

        // property to get or set the employee's working hours
        public double WorkingHours { get; set; }

        // default constructor
        public HourlyEmployee()
        {

        }

        // parameterized constructor that takes in the employee's SSN, first name, last name, birthdate, phone number, email, wage rate and working hours
        public HourlyEmployee(string? ssn, string? firstName, string? lastName, string? birthDay, string? phone, string? email, double wage, double workingHours) : base(ssn, firstName, lastName, birthDay, phone, email)
        {
            Wage = wage;
            WorkingHours = workingHours;
        }
    }

}
