namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a customer name is invalid.
    /// </summary>
    public class InValidCustomerNameException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidCustomerNameException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidCustomerNameException(string message = "Customer name must be greater than 0 and must contain no more than 40 characters") : base(message)
        {
        }
    }
}