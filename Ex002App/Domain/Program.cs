using ContactApplication;
//using System.Collections.Generics;

class Program
{
  static void Main(string[] args)
  {
    // App.Run();

    Dictionary<string, string> dic = new();

dic.Add("up", "вверх");
dic["down"]= "вниз";

var keys = dic.Keys;
foreach (string item in keys) Console.WriteLine(item);

var values = dic.Values;
foreach (string item in values) Console.WriteLine(item);

string value = dic["up"];
Console.WriteLine(value);
Console.WriteLine($"dic[\"up\"]= {dic["up"]}");

Console.WriteLine(dic.ContainsKey("down"));
Console.WriteLine(dic.ContainsKey("left"));

if (dic.ContainsKey("up"))
{
  dic["up"] = "верх";
}
else
{
  dic.Add("up", "вверх");
}

Console.WriteLine($"dic[\"up\"]= {dic["up"]}");
  }
}