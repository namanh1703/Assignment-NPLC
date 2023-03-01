namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a customer code is invalid.
    /// </summary>
    public class InValidCustomerCodeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidCustomerCodeException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidCustomerCodeException(string message = "Customer code must be greater than 0") : base(message)
        {
        }
    }
}