using Model;

namespace Infrastructure;

// public class CompanyContactCreator : ContactCreator
public class CompanyContactCreator : IContactCreator
{
  private string[] companyNames;

  public CompanyContactCreator()
  {
    this.companyNames = new string[]
    {
      "Компания 1",
      "Компания 2",
      "Компания 3",
    };
  }

  public Contact GetContact()
  {
    int length = this.companyNames.Length;
    string name = this.companyNames[Random.Shared.Next(length)];

    CompanyContact contact = new CompanyContact();
    contact.Name = name;

    string pattern = "+7 ({0}) {1}-{2}-{3}";
    contact.TelephoneNumber = string.Format(
      pattern,
      Random.Shared.Next(100, 1000), // {0}
      Random.Shared.Next(100, 1000), // {1}
      Random.Shared.Next(10, 100),   // {2}
      Random.Shared.Next(10, 100)    // {3}
    );

    contact.Fax = String.Format("+7 (911) {0}-{1}-{2}-{3}",
    Random.Shared.Next(10, 100),
    Random.Shared.Next(10, 100),
    Random.Shared.Next(10, 100),
    Random.Shared.Next(10, 100));

    contact.OGRN = $"{Random.Shared.Next(1000,10000)}";
    
    return contact;
  }

}