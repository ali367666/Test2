using MediatR;

namespace MediatRProJect;

public class CreateOrderCommand : IRequest<int>  // int: return type
{
    public string? ProductName { get; set; }
    public int Quantity { get; set; }
}

