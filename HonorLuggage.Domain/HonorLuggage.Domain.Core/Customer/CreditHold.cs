using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class CreditHold : CustomerState
    {
        public CreditHold(Customer customer) : base(customer)
        {
        }
    }
}
