using Infrastructure;
using Persistance;
using Model;

namespace ContactApplication;

public class App
{
  public static void Run()
  {
    200.Create("first_names.txt", "Имя");
    200.Create("last_names.txt", "Фамилия");

    UserContactCreator contactCreator = new UserContactCreator();
    Repository<UserContact> userRepository = new();
    CompanyContactCreator companyContactCreator = new CompanyContactCreator(userRepository);
    Repository<CompanyContact> companyRepository = new();

    for (int i = 0; i < 5; i++)
    {
      userRepository.Append((UserContact)contactCreator.GetContact());
      companyRepository.Append((CompanyContact)companyContactCreator.GetContact());
    }

    foreach (UserContact item in userRepository.GetAll())
    {
      Console.WriteLine(item.Nickname);
    }

    Console.WriteLine();

    foreach (CompanyContact item in companyRepository.GetAll())
    {
      Console.WriteLine(item.Nickname + "  " + item.ManagerId);
    }

    Console.WriteLine();

    foreach (CompanyContact item in companyRepository.GetAll())
    {
      Console.WriteLine($"{item.Name}: рук.: {userRepository.Get(item.ManagerId).FirstName}");
    }

  }
}