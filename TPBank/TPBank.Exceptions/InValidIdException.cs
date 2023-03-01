namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when an ID is invalid.
    /// </summary>
    public class InValidIdException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidIdException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidIdException(string message = "Id must not be null!") : base(message)
        {
        }
    }

}