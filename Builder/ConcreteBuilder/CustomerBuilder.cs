using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.ConcreteBuilder
{
    public class CustomerBuilder : ICustomerBuilder
    {
        private Customer _customer = new Customer();
        public void buildCustomerWithAddress(string address1, string address2, string city, string state)
        {
            _customer.Address1 = address1;
            _customer.Address2 = address2;
            _customer.City = city;
            _customer.State = state;
        }

        public void buildCustomerWithCustomerType(CustomerType customerType)
        {
            _customer.CustomerType = customerType;
        }

        public void buildCustomerWithEmail(string email)
        {
            _customer.Email = email;
        }

        public void buildCustomerWithFirstAndLastName(string firstName, string lastName)
        {
            _customer.FirstName = firstName;
            _customer.LastName = lastName;
        }

        public void buildCustomerWithPhoneNumber(long phoneNumber, PhoneType phoneType)
        {
            _customer.PhoneNumber = phoneNumber;
            _customer.PhoneType = phoneType;
        }

        public void buildCustomerWithZipCode(int zipCode)
        {
            _customer.ZipCode = zipCode;
        }

        public Customer getCustomer()
        {
            return this._customer;
        }
    }
}
