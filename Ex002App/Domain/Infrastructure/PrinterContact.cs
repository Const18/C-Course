using Model;

namespace Infrastructure;

public class PrinterContact
{
  public string Print(Contact contact)
  {
    string output = String.Empty;

    output += $"FirstName: {contact.FirstName}\n";
    output += $"LastName: {contact.LastName}\n";
    output += $"TelephoneNumber: {contact.TelephoneNumber}\n";
    output += $"DayOfBirth: {contact.DayOfBirth}\n";
    output += $"Email: {contact.Email}\n";

    return output;
  }
}