using System;
using Xunit;
using Wallet.Domain;
using Wallet.Application;

namespace Wallet.UnitTests
{
  public class CostumerTest
  {
    [Fact]
    public void Register__Return_Customer__When_Details_Are_Valid()
    {
      //
      //Arrange
      string expectName = "Wesley Santos";
      string expectPhoneNumber = "+55 31 9 9475 6634";

      IRegisterCustomerUseCase registerUc = new RegisterCustomerUseCase();

      //Act
      CustomerResult actualCustomerResult = registerUc.Register(expectName, expectPhoneNumber);

      //Assert
      Assert.NotNull(actualCustomerResult);
      Assert.NotEqual(Guid.Empty, actualCustomerResult.Id);
      Assert.Equal(expectName, actualCustomerResult.Name);
      Assert.Equal(expectPhoneNumber, actualCustomerResult.PhoneNumber);
    }

    [Fact]
    public void CustomerCreate__Returns_Customer()
    {
      //Arrange
      string expectName = "Wesley Santos";
      string expectPhoneNumber = "+55 31 9 9475 6634";

      //Act
      Customer customer = new Customer(expectName, expectPhoneNumber);
     
      //Assert
      Assert.NotNull(customer);
      Assert.NotEqual(Guid.Empty, customer.Id);
      Assert.Equal(expectName, customer.Name);
      Assert.Equal(expectPhoneNumber, customer.PhoneNumber);
    }
  }
}