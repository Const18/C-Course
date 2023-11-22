namespace Model;

public class CompanyContact : Contact
{
  public CompanyContact()
    : this("Default company", String.Empty, String.Empty)
  {
  }

  public CompanyContact(
    string name,
    string ogrn,
    string telephoneNumber) : base(telephoneNumber)
  {
    this.Name = name;
    this.OGRN = ogrn;
  }

  public string Fax { get; set; }
  public string Name { get; set; }
  public string OGRN { get; set; }
  public int ManagerId { get; set; }

  public override string Nickname => $"[{this.Name}, {this.OGRN}]";

  public override string ToString()
  {
    string output = String.Empty;
    output += $"Name: {this.Name}\n";
    output += $"OGRN: {this.OGRN}\n";
    output += base.ToString();
    output += $"Fax: {this.Fax}\n";

    return output;
  }
}