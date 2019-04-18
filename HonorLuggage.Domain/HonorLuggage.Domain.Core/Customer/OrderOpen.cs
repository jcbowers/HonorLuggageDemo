using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class OrderOpen : CustomerState
    {
        public OrderOpen(Customer customer) : base(customer)
        {
        }
    }
}
