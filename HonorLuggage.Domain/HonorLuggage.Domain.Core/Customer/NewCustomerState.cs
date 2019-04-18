﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HonorLuggage.Domain.Core.Customer
{
    class NewCustomerState : CustomerState
    {
        public NewCustomerState(Customer customer) : base(customer)
        {
        }

        internal override CustomerState Register()
        {
            return this;
        }
    }
}
