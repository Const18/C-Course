using Model;

namespace Extensions;

public static class ContactExtensions
{
  public static void Print(this Contact user)
  {
    Console.WriteLine("====");
    Console.WriteLine(user.Nickname);
    Console.WriteLine(user.TelephoneNumber);
    Console.WriteLine("====");
  }
}

