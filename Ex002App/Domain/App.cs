using Infrastructure;
using Persistance;

namespace ContactApplication;

public class App
{
  public static void Run()
  {
    PrinterRepository printerRepository = new();
    ContactCreator contactCreator = new();
    ContactRepository repo = new();

    for (int i = 0; i < 10; i++)
    {
      repo.Append(contactCreator.GetContact());
    }

    string res = printerRepository.Print(repo);
    Console.WriteLine(res);
  }
}