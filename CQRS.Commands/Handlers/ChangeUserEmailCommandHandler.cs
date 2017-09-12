using CQRS.Interfaces;

namespace CQRS.Commands.Handlers
{
    public class ChangeUserEmailCommandHandler : IHandler<ChangeUserEmailCommand>
    {
        public void Execute(ChangeUserEmailCommand command)
        {
            //
        }

    }
}
