using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    public interface ICustomerBuilder
    {
        public void buildCustomerWithFirstAndLastName(string firstName, string lastName);
        public void buildCustomerWithCustomerType(CustomerType customerType);
        public void buildCustomerWithPhoneNumber(long phoneNumber, PhoneType phoneType);
        public void buildCustomerWithEmail(string Email);
        public void buildCustomerWithAddress(string address1, string address2, string city, string state);
        public void buildCustomerWithZipCode(int zipCode);
        public Customer getCustomer();
    }
}
