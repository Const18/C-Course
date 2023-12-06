class Program
{
    static int x = 0;
  static void A()
  {
    for (int i = 0; i < 1000; i++)
    {
    //   Console.WriteLine($"A({x++}) ");
      File.AppendAllText("LogA.txt", $"A({x++})\n");
    //   Thread.Sleep(90);
    }
    Console.WriteLine($"Finish A({x})");
  }

  static void B()
  {
    for (int i = 0; i < 1000; i++)
    {
    //   Console.WriteLine($"B({x++}) ");
        File.AppendAllText("LogB.txt", $"B({x++})\n");
    //   Thread.Sleep(100);
    }
    Console.WriteLine($"Finish B({x})");
  }

  static void Main(string[] args)
  {
    Thread[] threads = new Thread[2]
    {
      new Thread(A),
      new Thread(B),
    };
    foreach (var item in threads) item.Start();

    for (int i = 0; i < 1000; i++)
    {
    //   Console.WriteLine($"C({x++}) ");
        File.AppendAllText("LogC.txt", $"C({x++})\n");
    //   Thread.Sleep(30);
    }
    Console.WriteLine($"Finish C({x})");
  }
}