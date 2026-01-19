using MediatR;

namespace MediatRProjects.Users.Commands.CreateUser;

public class CreateUserCommand: IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
