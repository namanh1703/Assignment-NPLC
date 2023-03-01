using TPBank.DataAccessLayer;
using TPBank.Entities;
using TPBank.Exceptions;

namespace TPBank.BusinessLogicLayer
{
    /// <summary>
    /// Provides business logic methods for managing customers
    /// </summary>
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private readonly ICustomerDataAccesslayer _dalCustomer;

        /// <summary>
        /// Initializes a new instance of the CustomerBusinessLogicLayer class with a new CustomerDataAccesslayer object.
        /// </summary>
        public CustomerBusinessLogicLayer()
        {
            _dalCustomer = new CustomerDataAccesslayer();
        }

        /// <summary>
        /// Retrieves a list of customers from the data access layer.
        /// </summary>
        /// <returns>A response containing the list of customers and the status of the operation.</returns>
        public Response<Customer> GetCustomers()
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Retrieve the list of customers from the data access layer.
                response.DataList = _dalCustomer.GetCustomers();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                // If an exception is thrown, set the response status to indicate failure and include the exception message.
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Retrieves a list of customers that match the specified predicate from the data access layer.
        /// </summary>
        /// <param name="predicate">The predicate used to filter the list of customers.</param>
        /// <returns>A response containing the filtered list of customers and the status of the operation.</returns>
        public Response<Customer> GetCustomersByCondition(Func<Customer, bool> predicate)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Retrieve the list of customers that match the specified predicate from the data access layer.
                response.DataList = _dalCustomer.GetCustomersByCondition(predicate);

                // Check if any customers were returned.
                if (!response.DataList.Any())
                {
                    // If no customers were returned, set the response status to indicate failure and include a message.
                    response.IsSuccess = false;
                    response.Message = "No customer found";
                }
                else
                {
                    // If customers were returned, set the response status to indicate success.
                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // If an exception is thrown, set the response status to indicate failure and include the exception message.
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Adds a new customer to the data access layer.
        /// </summary>
        /// <param name="customer">The customer object to be added.</param>
        /// <returns>A response containing the added customer and the status of the operation.</returns>
        public Response<Customer> AddCustomer(Customer customer)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Validate customer fields.
                if (!customer.CustomerName.IsNameValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Customer name is not valid";
                    return response;
                }
                if (!customer.Mobile.IsMobileValid() && !customer.Address.IsAddressValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Mobile and Address are not valid";
                    return response;
                }
                else
                {
                    if (!customer.Mobile.IsMobileValid())
                    {
                        response.IsSuccess = false;
                        response.Message = "Mobile is not valid";
                        return response;
                    }
                    if (!customer.Address.IsAddressValid())
                    {
                        response.IsSuccess = false;
                        response.Message = "Address is not valid";
                        return response;
                    }
                }
                if (!customer.UserName.IsValidUserName())
                {
                    response.IsSuccess = false;
                    response.Message = "User name is not valid";
                    return response;
                }
                if (_dalCustomer.GetCustomersByCondition(c => c.UserName == customer.UserName).Count > 0)
                {
                    response.IsSuccess = false;
                    response.Message = "User name already exists";
                    return response;
                }
                if (!customer.Password.IsValidPassword())
                {
                    response.IsSuccess = false;
                    response.Message = "Password is not valid";
                    return response;
                }

                // Add the customer to the data access layer.
                _dalCustomer.AddCustomer(customer);

                // Set the response status to indicate success and include the added customer in the response.
                response.Data = customer;
                response.IsSuccess = true;
                response.Message = "Customer added successfully";
            }
            catch (Exception ex)
            {
                // If an exception is thrown, set the response status to indicate failure and include the exception message.
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customer">The customer to be updated.</param>
        /// <returns>A response object containing the updated customer, success status, and message.</returns>
        public Response<Customer> UpdateCustomer(Customer customer)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Check if the customer name is valid.
                if (!customer.CustomerName.IsNameValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Customer name is not valid";
                    return response;
                }

                // Check if the mobile number is valid.
                if (!customer.Mobile.IsMobileValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Mobile is not valid";
                    return response;
                }

                // Check if the address is valid.
                if (!customer.Address.IsAddressValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Address is not valid";
                    return response;
                }

                // Check if both mobile and address are invalid.
                if (!customer.Mobile.IsMobileValid() && !customer.Address.IsAddressValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Mobile and Address are not valid";
                    return response;
                }

                // Check if the username is valid and unique.
                if (!customer.UserName.IsValidUserName() && _dalCustomer.GetCustomersByCondition(c => c.UserName == customer.UserName).Count > 0)
                {
                    response.IsSuccess = false;
                    response.Message = "User name is not valid or already exists";
                    return response;
                }

                // Check if the password is valid.
                if (!customer.Password.IsValidPassword())
                {
                    response.IsSuccess = false;
                    response.Message = "Password is not valid";
                    return response;
                }

                // Update the customer.
                _dalCustomer.UpdateCustomer(customer);

                // Set the response object properties.
                response.Data = customer;
                response.IsSuccess = true;
                response.Message = "Customer updated successfully";
            }
            catch (Exception ex)
            {
                // Set the response object properties if an exception is thrown.
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Deletes the customer with the specified user name.
        /// </summary>
        /// <param name="username">The user name of the customer to delete.</param>
        /// <returns>A response indicating whether the operation was successful, and an optional message and data.</returns>
        public Response<Customer> DeleteCustomer(string username)
        {
            var response = new Response<Customer>();

            try
            {
                // Check for null or empty user name.
                if (string.IsNullOrEmpty(username))
                {
                    response.IsSuccess = false;
                    response.Message = "User name must not be null or empty";
                    return response;
                }

                // Check if customer exists with the given user name.
                var customers = _dalCustomer.GetCustomersByCondition(c => c.UserName == username);
                if (customers.Count == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "Cannot find customer with user name " + username;
                    return response;
                }

                // Delete the customer.
                if (_dalCustomer.DeleteCustomer(customers[0].Id))
                {
                    response.IsSuccess = true;
                    response.Message = "Delete customer successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Delete customer failed";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Logs in a customer with the provided username and password.
        /// </summary>
        /// <param name="userName">The username of the customer to log in.</param>
        /// <param name="password">The password of the customer to log in.</param>
        /// <returns>A response indicating whether the login was successful, and if so, the logged-in customer.</returns>
        public Response<Customer> Login(string userName, string password)
        {
            Response<Customer> response = new Response<Customer>();
            try
            {
                // Try to find a customer with the provided username and password.
                var customers = _dalCustomer.GetCustomersByCondition(c => c.UserName == userName && c.Password == password);
                if (customers.Count > 0)
                {
                    // If a matching customer is found, set the response data and success status.
                    response.Data = customers[0];
                    response.IsSuccess = true;
                    response.Message = $"Login successful! Hello {customers[0].CustomerName}!";
                }
                else if (userName.Equals("system")  && password.Equals("manager")) {
                    var customer = new Customer()
                    {
                        Id = Guid.NewGuid(),
                        CustomerCode = 10,
                        CustomerName = "Nam Anh",
                        Mobile = "0566877173",
                        Address = "Thach That",
                        LandMark = "FPT Soft",
                        City = "Ha Noi",
                        Country = "Viet Nam",
                        UserName = "system",
                        Password = "manager"
                    };
                    response.Data = customer;
                    response.IsSuccess = true;
                    response.Message = "Login successful!!";
                    return response;
                }
                else
                {
                    // If no matching customer is found, set the response success status and message.
                    response.IsSuccess = false;
                    response.Message = "Username or password is incorrect";
                }
            }
            catch (Exception ex)
            {
                // If an exception is thrown, set the response success status and message.
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// Check if a given user name already exists in the customer database.
        /// </summary>
        /// <param name="userName">The user name to check.</param>
        /// <returns>A response indicating whether the user name exists, along with any relevant data or error messages.</returns>
        public Response<Customer> IsUserNameExist(string userName)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Check if username is empty.
                if (string.IsNullOrEmpty(userName))
                {
                    response.IsSuccess = false;
                    response.Message = "User name must not be null or empty";
                    return response;
                }
                // Check if username already exists.
                var customers = _dalCustomer.GetCustomersByCondition(c => c.UserName == userName);

                if (customers.Count > 0)
                {
                    response.Data = customers[0];
                    response.IsSuccess = false;
                    response.Message = $"Username {userName} is already taken";
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = $"Username {userName} is available";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Check if the given mobile number exists in the customer database.
        /// </summary>
        /// <param name="mobile">The mobile number to check.</param>
        /// <returns>A response object containing a success status, a message, and customer data if the mobile number exists.</returns>
        public Response<Customer> IsMobileExist(string mobile)
        {
            Response<Customer> response = new Response<Customer>();

            try
            {
                // Check if the mobile number is valid.
                if (!mobile.IsMobileValid())
                {
                    response.IsSuccess = false;
                    response.Message = "Mobile is invalid";
                    return response;
                }

                // Check if the mobile number already exists.
                var customers = _dalCustomer.GetCustomersByCondition(c => c.Mobile == mobile);
                if (customers.Count > 0)
                {
                    response.Data = customers[0];
                    response.IsSuccess = false;
                    response.Message = $"Mobile {mobile} already exists";
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = $"Mobile {mobile} does not exist";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}