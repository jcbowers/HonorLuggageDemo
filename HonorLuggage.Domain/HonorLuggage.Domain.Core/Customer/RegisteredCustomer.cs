using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class RegisteredCustomer : CustomerState
    {
        public RegisteredCustomer(Customer customer) : base(customer)
        {
        }
    }
}
