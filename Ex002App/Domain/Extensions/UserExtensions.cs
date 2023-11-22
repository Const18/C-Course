using Model;

namespace Extensions;

public static class UserExtensions
{
  public static void Print(this User user)
  {
    Console.WriteLine("====");
    Console.WriteLine(user.Login);
    Console.WriteLine(user.Password);
    Console.WriteLine("====");
  }
}

