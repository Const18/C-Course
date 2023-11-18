using Model;

namespace Infrastructure;

public class ContactCreator
{
  private string[] firstNames;
  private string[] lastNames;

  public ContactCreator(
    string pathToFistNamesFile = "first_names.txt",
    string pathToLastNamesFile = "last_names.txt")
  {
    this.firstNames = File.ReadAllLines(pathToFistNamesFile);
    this.lastNames = File.ReadAllLines(pathToLastNamesFile);
  }

  public Contact GetContact()
  {
    int lengthFn = firstNames.Length;
    int lengthLn = lastNames.Length;
    string firstName = this.firstNames[Random.Shared.Next(lengthFn)];
    string lastName = this.lastNames[Random.Shared.Next(lengthLn)];

    Contact contact = new Contact();
    contact.FirstName = firstName;
    contact.LastName = lastName;

    string pattern = "+7 ({0}) {1}-{2}-{3}";
    contact.TelephoneNumber = string.Format(
      pattern,
      Random.Shared.Next(100, 1000), // {0}
      Random.Shared.Next(100, 1000), // {1}
      Random.Shared.Next(10, 100),   // {2}
      Random.Shared.Next(10, 100)    // {3}
    );

    return contact;
  }

}