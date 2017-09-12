//using System;
//using CQRS.Interfaces.Command;
//using Microsoft.Extensions.DependencyInjection;
//using CQRS.Interfaces;

//namespace CQRS.Commands.Dispatcher
//{
//    public class CommandDispatcher : IDispatcher<ICommand>
//    {

//        private readonly IServiceProvider _serviceProvider;

//        public CommandDispatcher(IServiceProvider serviceProvider)
//        {
//            _serviceProvider = serviceProvider;
//        }

//        public void Dispatch(ICommand command)
//        {
//            var handler = _serviceProvider.GetService<IHandler<ICommand>>();
//            handler.Execute(command);
//        }
//    }
//}
