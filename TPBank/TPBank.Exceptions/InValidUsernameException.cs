namespace TPBank.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a username is invalid.
    /// </summary>
    public class InValidUsernameException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InValidUsernameException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InValidUsernameException(string message = "Username cannot be null and cannot be duplicated in the database") : base(message)
        {
        }
    }

}