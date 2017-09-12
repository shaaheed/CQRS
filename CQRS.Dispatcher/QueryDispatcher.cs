//using System;
//using CQRS.Interfaces.Query;
//using Microsoft.Extensions.DependencyInjection;
//using CQRS.Interfaces;

//namespace CQRS.Query.Dispatcher
//{
//    public class QueryDispatcher : IDispatcher<IQuery>
//    {

//        private readonly IServiceProvider _serviceProvider;

//        public QueryDispatcher(IServiceProvider serviceProvider)
//        {
//            _serviceProvider = serviceProvider;
//        }

//        public void Dispatch(IQuery query)
//        {
//            IHandler<IQuery> handler = _serviceProvider.GetService<IHandler<IQuery>>();
//            handler.Execute(query);
//        }
//    }
//}
