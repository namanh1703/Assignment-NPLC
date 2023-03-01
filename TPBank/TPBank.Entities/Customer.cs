using TPBank.Exceptions;

namespace TPBank.Entities
{
    /// <summary>
    /// Represents a customer in the system.
    /// </summary>
    public class Customer
    {
        private Guid _id;
        private long _customerCode;
        private string _customerName;
        private string _mobile;
        private string _address;
        private string _landMark;
        private string _city;
        private string _country;
        private string _userName;
        private string _password;

        public Guid Id
        {
            get => _id;
            set
            {
                if (!value.IsIdValid())
                {
                    throw new InValidIdException();
                }
                _id = value;
            }
        }

        /// <summary>
        /// The customer code.
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                if (!value.IsCodeValid())
                {
                    throw new InValidCustomerCodeException();
                }
                _customerCode = value;
            }
        }
        /// <summary>
        /// The name of the customer.
        /// </summary>
        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (!value.IsNameValid())
                {
                    throw new InValidCustomerNameException();
                }
                _customerName = value;
            }
        }

        /// <summary>
        /// The mobile number of the customer.
        /// </summary>
        public string Mobile
        {
            get => _mobile;
            set
            {
                if (!value.IsMobileValid())
                {
                    throw new InValidMobileException();
                }
                _mobile = value;
            }
        }

        /// <summary>
        /// The address of the customer.
        /// </summary>
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// The landmark of the customer's address.
        /// </summary>
        public string LandMark
        {
            get => _landMark;
            set => _landMark = value;
        }

        /// <summary>
        /// The city of the customer's address.
        /// </summary>
        public string City
        {
            get => _city;
            set => _city = value;
        }

        /// <summary>
        /// The country of the customer's address.
        /// </summary>
        public string Country
        {
            get => _country;
            set => _country = value;
        }

        /// <summary>
        /// The user name of the customer.
        /// </summary>
        public string UserName
        {
            get => _userName;
            set
            {
                if (!value.IsValidUserName())
                {
                    throw new InValidUsernameException();
                }
                _userName = value;
            }
        }

        /// <summary>
        /// The password of the customer.
        /// </summary>
        public string Password
        {
            get => _password;
            set
            {
                if (!value.Equals("manager") && !value.IsValidPassword() )
                {
                    throw new InValidPasswordException();
                }
                _password = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Customer class with the specified personal information and login credentials.
        /// </summary>
        /// <param name="customerCode">The unique code for the customer.</param>
        /// <param name="customerName">The full name of the customer.</param>
        /// <param name="mobile">The mobile number of the customer.</param>
        /// <param name="address">The address of the customer.</param>
        /// <param name="landMark">The nearby landmark of the customer.</param>
        /// <param name="city">The city where the customer resides.</param>
        /// <param name="country">The country where the customer resides.</param>
        /// <param name="userName">The username for the customer's account.</param>
        /// <param name="password">The password for the customer's account.</param>
        public Customer(long customerCode, string customerName, string mobile, string address, string landMark, string city, string country, string userName, string password)
        {
            _id = Guid.NewGuid();
            _customerCode = customerCode;
            _customerName = customerName;
            _mobile = mobile;
            _address = address;
            _landMark = landMark;
            _city = city;
            _country = country;
            _userName = userName;
            _password = password;
        }

        /// <summary>
        /// Initializes a new instance of the Customer class with default values.
        /// </summary>
        public Customer()
        {
            _id = Guid.NewGuid();
        }
        /// <summary>
        /// Returns a string that represents the current Customer object.
        /// </summary>
        /// <returns>Return CustomerCode, CustomerName, Mobile, Address, LandMark, City, Country, UserName, Password.</returns>
        public override string ToString()
        {
            return $"CustomerCode: {CustomerCode} --- CustomerName: {CustomerName} --- Mobile: {Mobile} --- Address: {Address} --- LandMark: {LandMark} --- City: {City} --- Country: {Country} --- UserName: {UserName} --- Password: {Password}";
        }
    }
}