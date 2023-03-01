namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a password is invalid.
    /// </summary>
    public class InValidPasswordException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidPasswordException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidPasswordException(string message = "Password cannot be null and must contain 6 or more characters including uppercase, lowercase and number") : base(message)
        {
        }
    }

}