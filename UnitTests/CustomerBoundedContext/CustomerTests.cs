using System;
using Xunit;
using FluentAssertions;

using Domain.Common;
using Domain.CustomerBoundedContext;

using Persistence.SqlDB;
using Persistence.SqlDB.CustomerBoundedContext;


namespace UnitTests.CustomerBoundedContext
{

    public class CustomerTests
    {

        [Fact]
        public void NewCustomerWithNullNameRaiseAnException()
        {

            Action action = () =>
            {
                Customer c = new Customer(null);
            };

            action.ShouldThrow<CustomerNameCannotBeNullException>();

        }

        [Fact]
        public void NewCustomerPersists()
        {
            Initer.Init(@"Server=(local);Database=test;Trusted_Connection=Yes;");
            DomainEvents.Init();
            CustomerRepository customerRepository = new CustomerRepository();
            Customer c = new Customer("Pietro");
            c.AddCustomerAddedEvent();
            Customer d = new Customer("Paolo");

            customerRepository.Save(d);
            
        }

        [Fact]
        public void CustomerId10HasNamePietro()
        {
            Initer.Init(@"Server=(local);Database=test;Trusted_Connection=Yes;");

            CustomerRepository customerRepository = new CustomerRepository();

            Customer c = customerRepository.GetById(10);

            c.Name.Should().Be("Pietro");

        }
    }
}
