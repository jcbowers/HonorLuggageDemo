using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class OrderEligible : CustomerState
    {
        public OrderEligible(Customer customer) : base(customer)
        {
        }
    }
}
