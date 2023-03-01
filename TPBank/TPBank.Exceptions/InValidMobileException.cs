namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a mobile phone number is invalid.
    /// </summary>
    public class InValidMobileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidMobileException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidMobileException(string message = "The phone number cannot be duplicated in the database and must contain 10 digits") : base(message)
        {
        }
    }

}