using System;
using System.Collections.Generic;

class Product
{
  private string _name;

  private string _productId;

  private double _pricePerUnit;

  private int _quantity;

  public Product(string name, string productId, double pricePerUnit, int quantity)
  {
    _name = name;
    _productId = productId;
    _pricePerUnit = pricePerUnit;
    _quantity = quantity;
  }

  public string getName()
  {
    return _name;
  }

  public void setName(string name)
  {
    _name = name;
  }

  public string getProductId()
  {
    return _productId;
  }

  public void setProductId(string productId)
  {
    _productId = productId;
  }

  public double getPricePerUnit()
  {
    return _pricePerUnit;
  }

  public void setPricePerUnit(double pricePerUnit)
  {
    _pricePerUnit = pricePerUnit;
  }

  public int getQuantity()
  {
    return _quantity;
  }

  public void setQuantity(int quantity)
  {
    _quantity = quantity;
  }
}
