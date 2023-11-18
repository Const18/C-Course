using Model;

namespace Persistance;

public class ContactRepository
{
  private List<Contact> storage;
  public ContactRepository()
  {
    storage = new List<Contact>();
  }

  public void Append(Contact contact)
  {
    this.storage.Add(contact);
  }

  public Contact[] GetAll()
  {
    return this.storage.ToArray();
  }

}