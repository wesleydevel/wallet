using System;

namespace Wallet.Domain
{
  public sealed class Customer
  {
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }

    public Customer(string Name, string PhoneNumber)
    {
      this.Id = Guid.NewGuid() ;
      this.Name = Name;
      this.PhoneNumber = PhoneNumber;
    }
  }
}