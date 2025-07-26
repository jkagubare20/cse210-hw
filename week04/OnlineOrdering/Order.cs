using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost;
    }
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetPackingLabel()
    {
        return $"Packing Label:\nCustomer: {_customer._name}\nAddress: {_customer._address.GetFormattedAddress()}\n";
    }

    public string GetShippingLabel()
    {
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return $"Shipping Label:\nShipping to: {_customer._address.GetFormattedAddress()}\nShipping Cost: {shippingCost:C}\n";
    }
}