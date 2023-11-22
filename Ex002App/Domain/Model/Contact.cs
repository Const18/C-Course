namespace Model;

public class Contact
{
  public Contact()
  {
    this.TelephoneNumber = String.Empty;
  }

  public Contact(string telephoneNumber)
  {
    this.TelephoneNumber = telephoneNumber;
  }
  
  public virtual string Nickname { get;}
  public string TelephoneNumber { get; set; }

    public override string ToString()
    {
      string output = String.Empty;
      output += $"TelephoneNumber: {this.TelephoneNumber}\n";
      return output;
    }
}