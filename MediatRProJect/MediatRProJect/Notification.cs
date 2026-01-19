using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class OrderCreatedNotification : INotification
{
    public int OrderId { get; set; }
}

public class EmailNotificationHandler : INotificationHandler<OrderCreatedNotification>
{
    public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Email göndərildi, OrderID: {notification.OrderId}");
        return Task.CompletedTask;
    }
}

public class SMSNotificationHandler : INotificationHandler<OrderCreatedNotification>
{
    public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"SMS göndərildi, OrderID: {notification.OrderId}");
        return Task.CompletedTask;
    }
}
