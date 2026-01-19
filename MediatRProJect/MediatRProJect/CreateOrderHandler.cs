using MediatR;
using MediatRProJect;
using System.Threading;
using System.Threading.Tasks;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, int>
{
    private readonly IMediator _mediator;

    public CreateOrderHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        // 1️⃣ Biznes əməliyyatı: Order yaratmaq
        int orderId = new Random().Next(1000, 9999);
        Console.WriteLine($"Order yaradıldı: {request.ProductName}, ID: {orderId}");

        // 2️⃣ Notification-u Publish etmək
        await _mediator.Publish(new OrderCreatedNotification { OrderId = orderId });

        return orderId;
    }
}
