class ArrayMethods
{
  // Считывания данных от пользователя из терминала
  public static int GetValueByUserFromTerminal(string text)
  {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
  }

  // Создания массива
  public static int[] CreateArray(int size)
  {
    int[] result = new int[size];
    return result;
  }

  #region void PrintToTerminal(...)
  // Печать массива в терминал
  public static void PrintToTerminal(int[] array)
  {
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
      Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
  }
  #endregion

  // Объединение массива в строку
  public static string Join(char separator, int[] array)
  {
    int count = array.Length;
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
      result += $"{array[i]}{separator}";
    }

    return result;
  }

  #region int[] Fill(...)
  // Заполнение массива случайно
  public static int[] FillAndReturn(int[] array, int min, int max)
  {
    int count = array.Length;
    int[] temp = new int[count];
    for (int i = 0; i < count; i++)
    {
      temp[i] = Random.Shared.Next(min, max);
    }
    return temp;
  }
  #endregion

  // Заполнение массива случайно
  public static void Fill(int[] array, int min, int max)
  {
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
      array[i] = Random.Shared.Next(min, max);
    }
  }
}