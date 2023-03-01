namespace DepartmentManage
{
    /// <summary>
    /// IPayable interface defines a method to get the payment amount of an employee.
    /// </summary>
    public interface IPayable
    {
        /// <summary>
        /// Gets the payment amount of an employee.
        /// </summary>
        /// <returns>The payment amount of an employee.</returns>
        double GetPaymentAmount();
    } 
}
