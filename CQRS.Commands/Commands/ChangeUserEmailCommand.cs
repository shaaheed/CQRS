using CQRS.Interfaces.Command;

namespace CQRS.Commands
{
    public class ChangeUserEmailCommand : ICommand
    {
        public string Email { get; set; }

        public ChangeUserEmailCommand(string email)
        {
            Email = email;
        }

    }
}
