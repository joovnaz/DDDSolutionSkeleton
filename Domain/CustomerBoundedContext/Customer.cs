using System;
using Domain.Common;

namespace Domain.CustomerBoundedContext
{
    
    public class Customer : AggregateRoot 
    {
        public virtual String Name { get; protected set; }

        protected Customer()
        {
            // Required by NHibernate
        }

        public Customer(string customerName)
        {
            if (customerName == null)
                throw new CustomerNameCannotBeNullException();

            Name = customerName;
        }


        public virtual void AddCustomerAddedEvent()
        {
            AddDomainEvent(new CustomerAddedEvent(this));
        }


    }
}
