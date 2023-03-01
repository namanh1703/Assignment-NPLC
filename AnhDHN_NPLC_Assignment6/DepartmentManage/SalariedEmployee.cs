namespace DepartmentManage
{
    /// <summary>
    /// The `SalariedEmployee` class represents a salaried employee, which is a type of `Employee`. 
    /// It contains properties for commission rate, gross sales, and basic salary.
    /// </summary>
    public class SalariedEmployee : Employee
    {
        // instance variables to hold commission rate, gross sales, and basic salary
        private readonly double commissionRate;
        private readonly double grossSales;
        private readonly double basicSalary;

        // public properties to access the instance variables
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        // default constructor
        public SalariedEmployee()
        {

        }

        // parameterized constructor that takes in the employee's SSN, first name, last name, birthdate, phone number, email, wage rate and working hours
        public SalariedEmployee(string? ssn, string? firstName, string? lastName, string? birthDay, string? phone, string? email, double commissionRate, double grossSales, double basicSalary) : base(ssn, firstName, lastName, birthDay, phone, email)
        {
            CommissionRate = commissionRate;
            GrossSales = grossSales;
            BasicSalary = basicSalary;
        }
    }

}
