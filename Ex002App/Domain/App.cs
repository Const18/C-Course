using Infrastructure;
using Persistance;
using Model;

namespace ContactApplication;

public class App
{
  public static void Run()
  {
    IContactCreator contactCreator = new UserContactCreator();
    IContactCreator companyContactCreator = new CompanyContactCreator();
    ContactRepository repo = new();
 
    for (int i = 0; i < 5; i++)
    {
      if(Random.Shared.Next(2)==0)
      {
        repo.Append(contactCreator.GetContact());
      }
      else 
      {
        repo.Append(companyContactCreator.GetContact());
      }
    }   

    foreach (Contact item in repo.GetAll())
    {
      Console.WriteLine(item.Nickname);
    }
  }
}