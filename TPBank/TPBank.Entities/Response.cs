namespace TPBank.Entities
{
    /// <summary>
    /// Represents a response object that can be returned by an API or service call.
    /// </summary>
    /// <typeparam name="T">The type of data contained in the response.</typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether the response was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the response, if any.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the data contained in the response, if any.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Gets or sets a collection of data items contained in the response, if any.
        /// </summary>
        public ICollection<T> DataList { get; set; }
    }
}