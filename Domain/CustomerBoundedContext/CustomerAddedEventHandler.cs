using System;
using Domain.Common;

namespace Domain.CustomerBoundedContext
{
    class CustomerAddedEventHandler : IHandler<CustomerAddedEvent>
    {
        public void Handle(CustomerAddedEvent domainEvent)
        {

            throw new NotImplementedException(string.Format("CustomerId={0}", domainEvent.GetCustomer().Id));
        }
    }
}
