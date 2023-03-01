using TPBank.BusinessLogicLayer;
using TPBank.Entities;
using TPBank.Exceptions;

namespace TPBank.Presentation
{
    /// <summary>
    /// The Manage class handles the user interface and business logic for the TPBank application.
    /// </summary>
    public class Manage
    {
        private readonly ICustomerBusinessLogicLayer _bllCustomer;
        private string? _customerName;

        /// <summary>
        /// Initializes a new instance of the Manage class.
        /// </summary>
        public Manage()
        {
            _bllCustomer = new CustomerBusinessLogicLayer();
        }

        /// <summary>
        /// Runs the TPBank application.
        /// </summary>
        public void Run()
        {
            Login();
            Menu();
        }

        /// <summary>
        /// Prompts the user to log in.
        /// </summary>
        private void Login()
        {
            string username, password;
            do
            {
                Console.Clear();
                Console.WriteLine("========== TPBank ==========");
                Console.WriteLine("::: Login :::");
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                Console.WriteLine("============================");

                // Attempts to log in the user and displays a message indicating success or failure
                var response = _bllCustomer.Login(username, password);
                if (response.IsSuccess)
                {
                    Console.WriteLine(response.Message);
                    _customerName = response.Data.CustomerName;
                    Thread.Sleep(1500);
                    break;
                }
                else
                {
                    Console.WriteLine(response.Message);
                    Thread.Sleep(2000);
                }
            } while (true);
        }

        /// <summary>
        /// Displays the main menu and allows the user to select an option.
        /// </summary>
        private void Menu()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("============= TPBank =============");
                Console.WriteLine("::: Main menu :::");
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. Get All Existing Customer");
                Console.WriteLine("3. Find customer");
                Console.WriteLine("4. Update customer");
                Console.WriteLine("5. Delete customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("==================================");
                Console.Write("Enter choice: ");
                // Reads the user's choice and handles the selected option
                choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        GetAllCustomer();
                        break;
                    case 3:
                        FindCustomer();
                        break;
                    case 4:
                        UpdateCustomer();
                        break;
                    case 5:
                        DeleteCustomer();
                        break;
                    case 0:
                        Console.WriteLine("\nGoodbye!");
                        Thread.Sleep(800);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        Thread.Sleep(800);
                        break;
                }
            } while (choice != 0);
        }
        /// <summary>
        /// Find Customer
        /// </summary>
        private void FindCustomer()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("::: Find Customer Menu :::");
                Console.WriteLine("1. Find By Username");
                Console.WriteLine("2. Find By Address");
                Console.WriteLine("3. Find By City");
                Console.WriteLine("4. Find By Mobile");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;

                // Execute a different method based on the user's choice
                switch (choice)
                {
                    case 1:
                        FindCustomerBy(choice);
                        break;
                    case 2:
                        FindCustomerBy(choice);
                        break;
                    case 3:
                        FindCustomerBy(choice);
                        break;
                    case 4:
                        FindCustomerBy(choice);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        Thread.Sleep(800);
                        break;
                }
            } while (choice != 0);
        }

        /// <summary>
        /// Finds customer based on provided choice and input value.
        /// </summary>
        /// <param name="choice">User's choice.</param>
        private void FindCustomerBy(int choice)
        {
            Console.Clear();
            Console.WriteLine("::: Find Customer :::");
            Console.Write("Enter value: ");
            string input = Console.ReadLine();

            var response = _bllCustomer.GetCustomersByCondition(c =>
            {
                switch (choice)
                {
                    case 1:
                        return c.UserName == input;
                    case 2:
                        return c.Address.Contains(input);
                    case 3:
                        return c.City.Contains(input);
                    case 4:
                        return c.Mobile == input;
                    default:
                        return false;
                }
            });

            if (response.IsSuccess)
            {
                Console.WriteLine("Found {0} customer(s)", response.DataList.Count);
                foreach (var customer in response.DataList)
                {
                    Console.WriteLine(customer.ToString());
                }
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }


        /// <summary>
        /// Retrieves all customers from the business logic layer and displays their details on the console.
        /// </summary>
        private void GetAllCustomer()
        {
            Console.Clear();
            var response = _bllCustomer.GetCustomers();

            if (response.IsSuccess)
            {
                Console.WriteLine("::: Customer List :::");
                var customers = response.DataList;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ToString());
                }
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
            }

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Deletes a customer.
        /// </summary>
        private void DeleteCustomer()
        {
            Console.Clear();
            Console.WriteLine("::: Delete customer :::");
            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            // Call business logic layer to delete the customer with the given username.
            var response = _bllCustomer.DeleteCustomer(username);

            if (response.IsSuccess)
            {
                Console.WriteLine($"\n{response.Message}");
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Adds a new customer after taking input for customer details from the user
        /// </summary>
        private void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("::: Add Customer :::");

            // Get username
            string username;
            do
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                var isUsernameExistResponse = _bllCustomer.IsUserNameExist(username);
                if (!isUsernameExistResponse.IsSuccess)
                {
                    Console.WriteLine(isUsernameExistResponse.Message);
                }
            } while (!_bllCustomer.IsUserNameExist(username).IsSuccess);

            // Get password
            string password;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (!password.IsValidPassword())
                {
                    Console.WriteLine("Password must be 6 characters long including uppercase and lowercase letters and numbers!");
                }
            } while (!password.IsValidPassword());

            // Get mobile number
            string mobile;
            do
            {
                Console.Write("Enter mobile: ");
                mobile = Console.ReadLine();
                var isMobileExistResponse = _bllCustomer.IsMobileExist(mobile);
                if (!isMobileExistResponse.IsSuccess)
                {
                    Console.WriteLine(isMobileExistResponse.Message);
                }
            } while (!_bllCustomer.IsMobileExist(mobile).IsSuccess);

            // Get customer name
            string name;
            do
            {
                Console.Write("Enter fullname: ");
                name = Console.ReadLine();
                if (!name.IsNameValid())
                {
                    Console.WriteLine("Name cannot be null and can only contain up to 40 characters");
                }
            } while (!name.IsNameValid());

            // Get address
            string address;
            do
            {
                Console.Write("Enter address: ");
                address = Console.ReadLine();
                if (!address.IsAddressValid())
                {
                    Console.WriteLine("Address cannot be null and can only contain up to 40 characters");
                }
            } while (!address.IsAddressValid());

            // Get city
            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            // Get landmark
            Console.Write("Enter landmark: ");
            string landmark = Console.ReadLine();

            // Get country
            Console.Write("Enter country: ");
            string country = Console.ReadLine();

            // Create a new customer object
            var customer = new Customer()
            {
                UserName = username,
                Password = password,
                Mobile = mobile,
                CustomerName = name,
                Address = address,
                City = city,
                LandMark = landmark,
                Country = country
            };

            // Add the customer to the system
            var response = _bllCustomer.AddCustomer(customer);
            if (response.IsSuccess)
            {
                Console.WriteLine($"\n{response.Message}");
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Allows user to update customer information
        /// </summary>
        private void UpdateCustomer()
        {
            Console.Clear();
            Console.WriteLine("::: Update Customer :::");
            Console.Write("Enter username you want to update: ");
            string username = Console.ReadLine();

            // Ensure username exists in database
            while (!_bllCustomer.IsUserNameExist(username).IsSuccess)
            {
                Console.WriteLine(_bllCustomer.IsUserNameExist(username).Message);
                Console.Write("Enter username you want to update: ");
                username = Console.ReadLine();
            }

            // Retrieve customer object based on username
            var customer = _bllCustomer.GetCustomersByCondition(c => c.UserName == username).DataList.First();

            Console.WriteLine("::: Customer Info :::");
            Console.WriteLine(customer.ToString());
            Console.WriteLine("=> Enter information you want to update (Address, Landmark, City, Mobile, Password), if input is null, default not change: ");

            // Update address
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(address))
            {
                customer.Address = address;
            }

            // Update city
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(city))
            {
                customer.City = city;
            }

            // Update landmark
            Console.Write("Enter landmark: ");
            string landmark = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(landmark))
            {
                customer.LandMark = landmark;
            }

            // Update country
            Console.Write("Enter country: ");
            string country = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(country))
            {
                customer.Country = country;
            }

            // Update mobile number
            Console.Write("Enter mobile: ");
            string mobile = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(mobile))
            {
                // Ensure mobile number is unique in database
                while (!_bllCustomer.IsMobileExist(mobile).IsSuccess)
                {
                    Console.WriteLine(_bllCustomer.IsMobileExist(mobile).Message);
                    Console.Write("Enter Mobile: ");
                    mobile = Console.ReadLine();
                }
                customer.Mobile = mobile;
            }

            // Update password
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(password))
            {
                // Ensure password meets required format
                while (!password.IsValidPassword())
                {
                    Console.WriteLine("Password must be 6 characters long including uppercase and lowercase letters and numbers!");
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                }
                customer.Password = password;
            }

            // Save updated customer information to database
            var response = _bllCustomer.UpdateCustomer(customer);
            if (response.IsSuccess)
            {
                Console.WriteLine($"\n{response.Message}");
            }
            else
            {
                Console.WriteLine($"\n{response.Message}");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}