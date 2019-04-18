namespace HonorLuggage.Domain.Core.Customer
{
    public class CustomerFactory
    {
        public Customer MakeCustomer(CustomerContext context)
        {
            return new Customer(context);
        }
    }
}
