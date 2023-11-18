namespace Model;

public class Contact
{
  public Contact()
  {
    this.FirstName = String.Empty;
    this.LastName = String.Empty;
    this.TelephoneNumber = String.Empty;
    this.DayOfBirth = DateOnly.MinValue;
    this.Email = "nil";
  }

  public Contact(
    string firstName,
    string lastName,
    string telephoneNumber,
    DateOnly dayOfBirth,
    string email)
  {
    this.FirstName = firstName;
    this.LastName = lastName;
    this.TelephoneNumber = telephoneNumber;
    this.DayOfBirth = dayOfBirth;
    this.Email = email;
  }

  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string TelephoneNumber { get; set; }
  public DateOnly DayOfBirth { get; set; }
  public string Email { get; set; }
}
