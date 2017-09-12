using System;
using CQRS.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dispatcher
{
    public class Dispatcher : IDispatcher
    {

        private readonly IServiceProvider _serviceProvider;

        public Dispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Dispatch<T>(T dispatch)
        {
            var handler = _serviceProvider.GetService<IHandler<T>>();
            handler.Execute(dispatch);
        }
    }
}
