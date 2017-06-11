using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain.Common
{
    public static class DomainEvents
    {
        private static List<Type> _handlers;

        public static void Init()
        {
            DomainEvents.ListAllHandlers();   
        }

        private static void ListAllHandlers()
        {
            _handlers = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.GetInterfaces()
                             .Any(y => y.IsGenericType 
                                    && y.GetGenericTypeDefinition() == typeof(IHandler<>)))
                .ToList();
        }

        public static void Dispatch(IDomainEvent domainEvent)
        {
            foreach (Type handlerType in _handlers)
            {
                Type domainType = domainEvent.GetType();

                if (CanHandleEvent(handlerType, domainType))
                {
                    dynamic handler = Activator.CreateInstance(handlerType);
                    handler.Handle((dynamic) domainEvent);
                }
            }
        }

        private static bool CanHandleEvent(Type handlerType, Type domainType)
        {
            return handlerType.GetInterfaces()
                .Any(x => x.IsGenericType
                          && x.GetGenericTypeDefinition() == typeof(IHandler<>)
                          && x.GenericTypeArguments[0] == domainType);
        }
    }
}
