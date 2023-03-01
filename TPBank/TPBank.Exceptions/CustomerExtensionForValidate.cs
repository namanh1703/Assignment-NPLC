using System.Text.RegularExpressions;

namespace TPBank.Exceptions
{
    /// <summary>
    /// Provides extension methods for validating customer-related data.
    /// </summary>
    public static class CustomerExtensionForValidate
    {
        /// <summary>
        /// Determines whether the specified customer name is valid.
        /// </summary>
        /// <param name="customerName">The name to validate.</param>
        /// <returns>true if the name is valid; otherwise, false.</returns>
        public static bool IsNameValid(this string customerName)
        {
            return !string.IsNullOrEmpty(customerName) && customerName.Length > 0 && customerName.Length <= 40;
        }

        /// <summary>
        /// Determines whether the specified customer code is valid.
        /// </summary>
        /// <param name="customerCode">The code to validate.</param>
        /// <returns>true if the code is valid; otherwise, false.</returns>
        public static bool IsCodeValid(this long customerCode)
        {
            return customerCode > 0;
        }

        /// <summary>
        /// Determines whether the specified ID is valid.
        /// </summary>
        /// <param name="id">The ID to validate.</param>
        /// <returns>true if the ID is valid; otherwise, false.</returns>
        public static bool IsIdValid(this Guid id)
        {
            return id != Guid.Empty;
        }

        /// <summary>
        /// Determines whether the specified mobile number is valid.
        /// </summary>
        /// <param name="mobile">The mobile number to validate.</param>
        /// <returns>true if the mobile number is valid; otherwise, false.</returns>
        public static bool IsMobileValid(this string mobile)
        {
            return !string.IsNullOrEmpty(mobile) && !string.IsNullOrWhiteSpace(mobile) && Regex.IsMatch(mobile, @"^[0-9]{10,12}$");
        }

        /// <summary>
        /// Determines whether the specified address is valid.
        /// </summary>
        /// <param name="address">The address to validate.</param>
        /// <returns>true if the address is valid; otherwise, false.</returns>
        public static bool IsAddressValid(this string address)
        {
            return !string.IsNullOrEmpty(address) && !string.IsNullOrWhiteSpace(address) && address.Length > 0 && address.Length <= 40;
        }

        /// <summary>
        /// Determines whether the specified user name is valid.
        /// </summary>
        /// <param name="userName">The user name to validate.</param>
        /// <returns>true if the user name is valid; otherwise, false.</returns>
        public static bool IsValidUserName(this string userName)
        {
            return !string.IsNullOrEmpty(userName) && !string.IsNullOrWhiteSpace(userName) && userName.Length > 0;
        }

        /// <summary>
        /// Determines whether the specified password is valid.
        /// </summary>
        /// <param name="password">The password to validate.</param>
        /// <returns>true if the password is valid; otherwise, false.</returns>
        public static bool IsValidPassword(this string password)
        {
            return !string.IsNullOrEmpty(password) && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$");
        }
    }
}