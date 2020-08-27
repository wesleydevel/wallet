using System;
using System.Collections.Generic;
using Wallet.Domain;

namespace Wallet.Application
{
  public sealed class CustomerResult
  {
    public CustomerResult(Customer customer)
    {
      Id = customer.Id;
      Name = customer.Name;
      PhoneNumber = customer.PhoneNumber;
    }
    public Guid Id { get; }
    public string Name { get; }
    public string PhoneNumber { get; }
  }
}