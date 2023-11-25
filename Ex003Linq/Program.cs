using System.Linq;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {

        var fs = new StreamReader("numbers.txt");
        int sum = 0;
        while(!fs.EndOfStream)
        {
            int v = int.Parse(fs.ReadLine());
            if(v % 3 == 0)
                sum += v;
        }
        Console.WriteLine(sum);
        fs.Close();

        Console.WriteLine(File.ReadAllLines("numbers.txt").Select(int.Parse).Where(x => x % 3 == 0).Sum());
    }
}