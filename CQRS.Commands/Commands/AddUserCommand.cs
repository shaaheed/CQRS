using CQRS.Interfaces.Command;

namespace CQRS.Commands
{
    public class AddUserCommand : ICommand
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public AddUserCommand(int id, string userName, string email)
        {
            Id = id;
            UserName = userName;
            Email = email;
        }

    }
}
