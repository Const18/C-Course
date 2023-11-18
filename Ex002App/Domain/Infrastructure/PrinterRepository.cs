using Persistance;

namespace Infrastructure;

public class PrinterRepository
{
  public string Print(ContactRepository repository)
  {
    PrinterContact pc = new PrinterContact();
    string output = String.Empty;

    var contacts = repository.GetAll();

    for (int i = 0; i < contacts.Length; i++)
    {
      output += $"{pc.Print(contacts[i])}\n";
    }

    return output;
  }
}