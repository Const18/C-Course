string message = "Value1: ";
Console.Write(message); // Вывод на экран
int number1 = int.Parse(Console.ReadLine()); // считывание данных из терминал

message = "Value2: ";
Console.Write(message); // Вывод на экран
int number2 = int.Parse(Console.ReadLine()); // считывание данных из терминал

int result = number1 + number2; // получение суммы

string output = $"{number1} + {number2} = {result}";
Console.WriteLine(output); // Вывод результата