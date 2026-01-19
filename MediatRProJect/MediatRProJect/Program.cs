using MediatR;
using MediatRProJect;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Mediator register
services.AddMediatR(typeof(Program));

var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();

var command = new CreateOrderCommand
{
    ProductName = "Laptop",
    Quantity = 2
};

// Command göndəririk → Handler icra olunur → Handler içində Publish çağırılır
int orderId = await mediator.Send(command);
