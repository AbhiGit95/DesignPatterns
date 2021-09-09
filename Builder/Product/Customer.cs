using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Builder.Product
{
    public class Customer
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public CustomerType CustomerType { get; set; }
       [Phone]
       public long PhoneNumber { get; set; }

       public PhoneType PhoneType { get; set; }

       [EmailAddress]
       public string Email { get; set; } 

       [MaxLength(200)]
       public string Address1 { get; set; }

       [MaxLength(100)] 
       public string Address2 { get; set; }
        
       [MaxLength(100)]
       public string City { get; set; }

       [MaxLength(100)]
       public string State { get; set; } 
       public int ZipCode { get; set; }

    }

    public enum CustomerType
    {
        Loyal,
        New,
        Returning
    }

    public enum PhoneType
    {
        Home,
        Work,
        Mobile
    }
}
