using TPBank.Entities;

namespace TPBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for managing customers.
    /// </summary>
    public interface ICustomerBusinessLogicLayer
    {
        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns>A response object containing the list of customers.</returns>
        public Response<Customer> GetCustomers();

        /// <summary>
        /// Gets customers based on a condition.
        /// </summary>
        /// <param name="predicate">A condition to filter customers.</param>
        /// <returns>A response object containing the list of customers.</returns>
        public Response<Customer> GetCustomersByCondition(Func<Customer, bool> predicate);

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">The customer object to add.</param>
        /// <returns>A response object containing the added customer.</returns>
        public Response<Customer> AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer object to update.</param>
        /// <returns>A response object containing the updated customer.</returns>
        public Response<Customer> UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes a customer by their username.
        /// </summary>
        /// <param name="username">The username of the customer to delete.</param>
        /// <returns>A response object indicating whether the delete was successful.</returns>
        public Response<Customer> DeleteCustomer(string username);

        /// <summary>
        /// Logs in a customer with the specified username and password.
        /// </summary>
        /// <param name="userName">The username of the customer.</param>
        /// <param name="password">The password of the customer.</param>
        /// <returns>A response object indicating whether the login was successful.</returns>
        public Response<Customer> Login(string userName, string password);

        /// <summary>
        /// Checks if a username already exists.
        /// </summary>
        /// <param name="userName">The username to check.</param>
        /// <returns>A response object indicating whether the username exists.</returns>
        public Response<Customer> IsUserNameExist(string userName);

        /// <summary>
        /// Checks if a mobile number already exists.
        /// </summary>
        /// <param name="mobile">The mobile number to check.</param>
        /// <returns>A response object indicating whether the mobile number exists.</returns>
        public Response<Customer> IsMobileExist(string mobile);
    }

}