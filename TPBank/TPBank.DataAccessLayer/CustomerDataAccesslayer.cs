using TPBank.Entities;

namespace TPBank.DataAccessLayer
{
    /// <summary>
    /// Provides data access for the customer entity.
    /// </summary>
    public class CustomerDataAccesslayer : ICustomerDataAccesslayer
    {
        private List<Customer> _customers;


        /// <summary>
        /// Initializes a new instance of the CustomerDataAccessLayer class.
        /// </summary>
        public CustomerDataAccesslayer()
        {
            _customers = new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 1,
                    CustomerName = "Nam Anh",
                    Mobile = "0585877173",
                    Address = "Thach That",
                    LandMark = "FPT Soft",
                    City = "Ha Noi",
                    Country = "Viet Nam",
                    UserName = "Admin",
                    Password = "Admin123"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 2,
                    CustomerName = "Smith",
                    Mobile = "1234567891",
                    Address = "Address 2",
                    LandMark = "LandMark 2",
                    City = "City 2",
                    Country = "Country 2",
                    UserName = "Smith1",
                    Password = "Smith01"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 3,
                    CustomerName = "Jeams",
                    Mobile = "1234567892",
                    Address = "Address 3",
                    LandMark = "LandMark 3",
                    City = "City 3",
                    Country = "Country 3",
                    UserName = "Jeams1",
                    Password = "Jeams01"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 4,
                    CustomerName = "David",
                    Mobile = "1234567893",
                    Address = "Address 4",
                    LandMark = "LandMark 4",
                    City = "City 4",
                    Country = "Country 4",
                    UserName = "David1",
                    Password = "David01"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 5,
                    CustomerName = "Joeth",
                    Mobile = "1234567894",
                    Address = "Address 5",
                    LandMark = "LandMark 5",
                    City = "City 5",
                    Country = "Country 5",
                    UserName = "Joeth1",
                    Password = "Joeth01"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 6,
                    CustomerName = "Jinx",
                    Mobile = "1234567895",
                    Address = "Address 2",
                    LandMark = "LandMark 2",
                    City = "City 2",
                    Country = "Country 2",
                    UserName = "Jinx1",
                    Password = "Jinx01"
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CustomerCode = 7,
                    CustomerName = "Garen",
                    Mobile = "1234567896",
                    Address = "Address 2",
                    LandMark = "LandMark 2",
                    City = "City 2",
                    Country = "Country 2",
                    UserName = "Garen1",
                    Password = "Garen01"
                },
            };
        }


        /// <summary>
        /// Gets a list of all customers.
        /// </summary>
        /// <returns>A list of all customers.</returns>
        public List<Customer> GetCustomers()
        {
            return _customers;
        }


        /// <summary>
        /// Gets a list of customers that match a specified condition.
        /// </summary>
        /// <param name="predicate">A function to test each customer for a condition.</param>
        /// <returns>A list of customers that match the specified condition.</returns>
        public List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate)
        {
            return _customers.Where(predicate).ToList();
        }


        /// <summary>
        /// Adds a new customer to the database.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        /// <returns>The ID of the newly added customer.</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                customer.CustomerCode = _customers.Max(c => c.CustomerCode) + 1;
                _customers.Add(customer);
                return customer.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the customer.", ex);
            }
        }


        /// <summary>
        /// Updates an existing customer in the collection of customers.
        /// </summary>
        /// <param name="customer">The updated customer object.</param>
        /// <returns>true if the customer was successfully updated, false otherwise.</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                // Find the customer to update by its ID.
                var customerToUpdate = _customers.FirstOrDefault(c => c.Id == customer.Id);
                if (customerToUpdate == null)
                {
                    // If the customer does not exist, return false.
                    return false;
                }

                // Update the customer's properties.
                customerToUpdate.CustomerName = customer.CustomerName;
                customerToUpdate.Address = customer.Address;
                customerToUpdate.Mobile = customer.Mobile;
                customerToUpdate.LandMark = customer.LandMark;
                customerToUpdate.City = customer.City;
                customerToUpdate.Country = customer.Country;
                customerToUpdate.UserName = customer.UserName;
                customerToUpdate.Password = customer.Password;

                // Return true to indicate success.
                return true;
            }
            catch (Exception e)
            {
                // If an exception occurs, throw a new exception with the same message.
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// Deletes a customer with the specified ID from the customer list.
        /// </summary>
        /// <param name="id">The unique identifier of the customer to delete.</param>
        /// <returns>True if the customer was successfully deleted; otherwise, false.</returns>
        public bool DeleteCustomer(Guid id)
        {
            // Check if the ID is valid
            if (id == Guid.Empty)
            {
                return false;
            }

            // Find the customer to delete
            var customerToDelete = _customers.FirstOrDefault(c => c.Id == id);
            if (customerToDelete == null)
            {
                return false;
            }

            // Remove the customer from the list
            _customers.Remove(customerToDelete);

            return true;
        }
    }
}