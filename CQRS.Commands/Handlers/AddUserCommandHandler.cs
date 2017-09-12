using System;
using CQRS.Interfaces;

namespace CQRS.Commands.Handlers
{
    public class AddUserCommandHandler : IHandler<AddUserCommand>
    {
        public void Execute(AddUserCommand command)
        {
            //
        }
    }
}
