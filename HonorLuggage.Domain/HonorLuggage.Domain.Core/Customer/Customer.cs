using System;

namespace HonorLuggage.Domain.Core.Customer
{
    public class Customer : Entity
    {
        private readonly CustomerContext _context;

        internal Customer(CustomerContext context) => _context = context;

        internal void Register()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal void MakeOrderEligible()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal void MakePremiumOrderEligible()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal void OpenOrder()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal void CloseOrder()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal void PlaceOnCreditHold()
        {
            throw new BusinessException("Invalid operation for the current state");
        }
    }
}
