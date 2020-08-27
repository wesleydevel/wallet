namespace Wallet.Application
{
  public interface IRegisterCustomerUseCase
  {
    CustomerResult Register(string expectName, string expectPhoneNumber);
  }
}