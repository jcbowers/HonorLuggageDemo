using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class PremiumOrderEligible : CustomerState
    {
        public PremiumOrderEligible(Customer customer) : base(customer)
        {
        }
    }
}
