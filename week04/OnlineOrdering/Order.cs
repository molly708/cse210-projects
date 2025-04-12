using System;
using System.Collections.Generic;

class Order
{
  private List<Product> _products;

  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";

    foreach (Product product in _products)
    {
      label += $"{product.getName()} (ID: {product.getProductId()})\n";
    }

    return label;
  }

  public string GetShippingLabel()
  {
     return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
  }

  public decimal CalculateTotalCost()
  {
    decimal totalCost = 0;

    foreach (Product product in _products)
    {
      decimal productCost = (decimal)product.getPricePerUnit() * product.getQuantity();

      totalCost += productCost;
    }

    bool IsInUSA = _customer.LivesInUSA();

    // USA shipping cost
    if (IsInUSA)
    {
      totalCost += 5;
    }

    // International shipping cost
    else
    {
      totalCost += 35;
    }
    
    // Step 8: Return the final total cost
    return totalCost;

  }
}