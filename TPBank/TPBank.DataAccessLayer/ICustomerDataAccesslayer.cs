using TPBank.Entities;

namespace TPBank.DataAccessLayer
{
    /// <summary>
    ///  Data Access layer for managing customers.
    /// </summary>
    public interface ICustomerDataAccesslayer
    {
        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>The list of customers.</returns>
        public List<Customer> GetCustomers();

        /// <summary>
        /// Retrieves a list of customers that satisfy a given condition.
        /// </summary>
        /// <param name="predicate">A function that takes a customer and returns true if it satisfies the condition, false otherwise.</param>
        /// <returns>The list of customers that satisfy the condition.</returns>
        public List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate);

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        /// <returns>The ID of the newly added customer.</returns>
        public Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customer">The updated customer.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        public bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes a customer with the given ID.
        /// </summary>
        /// <param name="id">The ID of the customer to delete.</param>
        /// <returns>True if the deletion was successful, false otherwise.</returns>
        public bool DeleteCustomer(Guid id);
    }
}