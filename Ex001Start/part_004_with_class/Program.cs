class Program
{
  // Клиентский код
  public static void Main()
  {
    int size = ArrayMethods.GetValueByUserFromTerminal("Сколько элементов нужно: ");
    int[] numbers = ArrayMethods.CreateArray(size);
    string output = ArrayMethods.Join(' ', numbers);
    Console.WriteLine(output);
    File.WriteAllText("numbers1.txt", output);
    ArrayMethods.Fill(numbers, 0, 10);

    output = ArrayMethods.Join(' ', numbers);
    Console.WriteLine(output);
    File.WriteAllText("numbers2.txt", output);

    int[] arr = ArrayMethods.CreateArray(10);
    int[] fillArr = ArrayMethods.FillAndReturn(arr, 0, 5);
    ArrayMethods.PrintToTerminal(arr);
    ArrayMethods.PrintToTerminal(fillArr);
  }
}