using Domain.Common;

namespace Domain.CustomerBoundedContext
{
    public class CustomerAddedEvent : IDomainEvent
    {
        Customer _c;

        public CustomerAddedEvent(Customer c)
        {
            _c = c;
        }

        public Customer GetCustomer()
        {
            return _c;
        }
    }
}