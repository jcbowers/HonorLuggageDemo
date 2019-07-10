namespace HonorsLuggage.Domain.Core.Customer
{
    abstract class CustomerState
    {
        internal CustomerState(Customer customer) => Customer = customer;

        internal Customer Customer { get; }

        internal virtual CustomerState Register()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal virtual CustomerState MakeOrderEligible()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal virtual CustomerState MakePremiumOrderEligible()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal virtual CustomerState OpenOrder()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal virtual CustomerState CloseOrder()
        {
            throw new BusinessException("Invalid operation for the current state");
        }

        internal virtual CustomerState PlaceOnCreditHold()
        {
            throw new BusinessException("Invalid operation for the current state");
        }
    }
}
