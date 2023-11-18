Console.Write("Введите Ваше имя: ");
string fullName = Console.ReadLine();

if (fullName == "Admin")
{
  Console.WriteLine("Я так ждала вас, Админ!");
}
else
{
  Console.WriteLine($"Привет, {fullName}!");
}