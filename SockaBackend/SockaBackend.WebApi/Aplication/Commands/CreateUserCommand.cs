using MediatR;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Mail { get; }

        public CreateUserCommand(string id,string name, string surname, string mail)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Mail = mail;
        }
    }
}
