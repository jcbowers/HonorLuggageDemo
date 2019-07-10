using System;
using System.Collections.Generic;
using System.Text;

namespace HonorsLuggage.Domain.Core.Customer
{
    class OrderEligible : CustomerState
    {
        public OrderEligible(Customer customer) : base(customer)
        {
        }
    }
}
