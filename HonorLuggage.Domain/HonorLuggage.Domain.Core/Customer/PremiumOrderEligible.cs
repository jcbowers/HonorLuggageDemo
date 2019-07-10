using System;
using System.Collections.Generic;
using System.Text;

namespace HonorsLuggage.Domain.Core.Customer
{
    class PremiumOrderEligible : CustomerState
    {
        public PremiumOrderEligible(Customer customer) : base(customer)
        {
        }
    }
}
