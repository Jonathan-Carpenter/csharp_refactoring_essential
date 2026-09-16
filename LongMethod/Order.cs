namespace LongMethod;

using System;
using System.Collections.Generic;

public class Order
{
    private readonly List<OrderItem> _items;
    private readonly Customer _customer;

    public Order(List<OrderItem> items, Customer customer)
    {
        _items = items;
        _customer = customer;
    }

    public OrderSummary Summarise()
    {
        Validate();

        // Subtotal calculation
        double subtotal = 0.0;
        foreach (var item in _items)
        {
            subtotal += item.Price * item.Quantity;
        }

        // Discount rules
        double discount = 0.0;
        if (_customer.IsLoyal)
        {
            discount = subtotal * 0.10;
        }
        else if (subtotal > 100)
        {
            discount = subtotal * 0.05;
        }

        // Tax calculation
        double taxableAmount = subtotal - discount;
        double tax = taxableAmount * 0.20;

        // Total calculation
        double total = taxableAmount + tax;

        return new OrderSummary(subtotal, discount, tax, total);
    }

    private void Validate()
    {
        if (_items == null)
        {
            throw new InvalidOperationException("Items cannot be null");
        }

        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Order must contain items");
        }
    }
}