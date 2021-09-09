using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Director
{
    public class CustomerCreationConfiguration
    {

        public Customer buildCustomer(ICustomerBuilder customerBuilder)
        {
            customerBuilder.buildCustomerWithFirstAndLastName("Abhigyan", "Sinha");
            customerBuilder.buildCustomerWithPhoneNumber(4699961466, PhoneType.Mobile);

            return customerBuilder.getCustomer();
        }

    }
}
