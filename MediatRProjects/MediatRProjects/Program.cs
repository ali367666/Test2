using MediatR;
using MediatRProjects.Users.Commands.CreateUser;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // DI container
        var services = new ServiceCollection();
        services.AddMediatR(typeof(CreateUserCommand).Assembly);

        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        // Yeni user command
        var command = new CreateUserCommand
        {
            FirstName = "Ali",
            LastName = "Ahmedov"
        };

        int userId = await mediator.Send(command);
        string f = command.FirstName + " " + command.LastName;

        Console.WriteLine($"User ID: {userId}");
        Console.WriteLine($"User Name: {f}");

    }
}
