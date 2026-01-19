using MediatR;

namespace MediatRProjects.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    
    public Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Random().Next(1, 1000));
    }
}
