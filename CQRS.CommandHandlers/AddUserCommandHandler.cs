using System;
using CQRS.Commands;
using CQRS.Interfaces;

namespace CQRS.CommandHandlers
{
    public class AddUserCommandHandler : ICommandHandler<AddUserCommand>
    {

        public AddUserCommandHandler()
        {

        }

        public void Execute(AddUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
