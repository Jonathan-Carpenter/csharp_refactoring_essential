namespace LongMethod;

using System;
using System.Collections.Generic;

public class Order
{
    private const double TaxRate = 0.20;

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

        var rawItemsTotal = GetRawItemsTotal();

        var discount = GetDiscount(rawItemsTotal);

        // Tax calculation
        double taxableAmount = rawItemsTotal - discount;
        double tax = taxableAmount * TaxRate;

        // Total calculation
        double total = taxableAmount + tax;

        return new OrderSummary(rawItemsTotal, discount, tax, total);
    }

    private double GetDiscount(double rawItemsTotal)
    {
        var discount = 0.0;
        if (_customer.IsLoyal)
        {
            discount = rawItemsTotal * 0.10;
        }
        else if (rawItemsTotal > 100)
        {
            discount = rawItemsTotal * 0.05;
        }

        return discount;
    }

    private double GetRawItemsTotal()
    {
        double rawItemsTotal = 0.0;
        foreach (var item in _items)
        {
            rawItemsTotal += item.Price * item.Quantity;
        }

        return rawItemsTotal;
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