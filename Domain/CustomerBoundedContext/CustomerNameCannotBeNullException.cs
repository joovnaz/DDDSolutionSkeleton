using System;
using System.Runtime.Serialization;

namespace Domain.CustomerBoundedContext
{
    [Serializable]
    public class CustomerNameCannotBeNullException : Exception
    {
        public CustomerNameCannotBeNullException()
        {
        }

        public CustomerNameCannotBeNullException(string message) : base(message)
        {
        }

        public CustomerNameCannotBeNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomerNameCannotBeNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}