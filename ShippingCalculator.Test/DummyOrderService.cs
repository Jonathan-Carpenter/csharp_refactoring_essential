using LegacyCode;

namespace ShippingCalculator.Test;

public class DummyOrderService : IOrderService
{
    private readonly Order? order;

    public DummyOrderService(Order? order)
    {
        this.order = order;
    }

    public Order GetOrder(int orderId)
    {
        return order;
    }
}