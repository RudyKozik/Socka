using MediatR;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; }
        public string Surname { get; }
        public string Mail { get; }

        public CreateUserCommand(string name, string surname, string mail)
        {
            Name = name;
            Surname = surname;
            Mail = mail;
        }
    }
}
