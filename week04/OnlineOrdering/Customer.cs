using System;
using System.Collections.Generic;

class Customer
{
  private string _name;
  private Address _address;

  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  // Getter for name
  public string GetName()
  {
    return _name;
  }

  // Setter for Name
  public void SetName(string name)
  {
    _name = name;
  }

  public Address GetAddress()
  {
    return _address;
  }

  public void SetAddress(Address address)
  {
    _address = address;
  }

  public bool LivesInUSA()
  {
    return _address.IsInUSA();
  }
}