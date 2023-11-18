namespace Model;

public class User
{
  public User(string login)
  {
    Password = Guid.NewGuid().ToString().Substring(0, 8);
    this.Login = login;
  }

  public string Login { get; set; }
  public string Password { get; set; }
}