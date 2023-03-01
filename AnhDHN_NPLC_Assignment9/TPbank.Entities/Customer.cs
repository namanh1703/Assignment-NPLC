﻿using TPbank.Entities.Contracts;
using TPBank.Exceptions;
namespace TPbank.Entities
{

    /// <summary>
    /// Represents customer of the bank
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        private Guid _customerID;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;

        /// <summary>
        /// Guid of Customer for Unique Identification
        /// </summary>
        public Guid CustomerID { get => _customerID; set => _customerID = value; }

        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set //set => _customerCode = value; (for Amara)
            {
                //customer code should be positive
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code should positive only");
                }
            }
        }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string CustomerName
        {
            get => _customerName;
            set
            {
                //customer name should be less than 40 characters
                if (value.Length <= 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("Customer name should not be null and less than 40 characters long");
                }
            }
        }

        /// <summary>
        /// Address of the customer
        /// </summary>
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// Landmark of the customer's address
        /// </summary>
        public string Landmark { get => _landmark; set => _landmark = value; }

        /// <summary>
        /// City of the customer
        /// </summary>
        public string City { get => _city; set => _city = value; }

        /// <summary>
        /// Country of trhe customer
        /// </summary>
        public string Country { get => _country; set => _country = value; }

        /// <summary>
        /// 10-digits Mobile number of the customer
        /// </summary>
        public string Mobile
        {
            get => _mobile;
            set
            {
                if (value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be a 10-digit number");
                }
            }
        }

        public object Clone()
        {
            return new Customer()
            {
                CustomerID = this.CustomerID,
                CustomerCode = this.CustomerCode,
                CustomerName = this.CustomerName,
                Address = this.Address,
                Landmark = this.Landmark,
                City = this.City,
                Country = this.Country,
                Mobile = this.Mobile
            };
        }
    }
}