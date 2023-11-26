class Program
{
    public static void Main(string[] args)
    {
        Cars car = new(150);
        // car.Actions();

        var day1 = FillDay(50, 75, 30);
        foreach(var item in day1)
            Console.WriteLine($"{item.Key} = [{String.Join(",", item.Value)}]");
        
        Console.WriteLine("====");

        var day2 = FillDay(50, 75, 30);
        foreach(var item in day2)
            Console.WriteLine($"{item.Key} = [{String.Join(",", item.Value)}]");

        Console.WriteLine("IDшники лояльных пользователей:");
        foreach (var item in day1)
        {
            if(day2.ContainsKey(item.Key))
            {
                HashSet<int> unionSet = new(item.Value);
                unionSet.UnionWith(day2[item.Key]);
                if(unionSet.Count > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }

    private static Dictionary<int, HashSet<int>> FillDay(int CountRecord, int MaxIdCustomer, int MaxIdPage)
    {
        Dictionary<int, HashSet<int>> res = new();
        for (int i = 0; i < CountRecord; i++)
        {
            int IdCoustomer = Random.Shared.Next(MaxIdCustomer);
            int IdPage = Random.Shared.Next(MaxIdCustomer);
            if(!res.ContainsKey(IdCoustomer))
            {
                res[IdCoustomer] = new();
            }
            res[IdCoustomer].Add(IdPage);
        }
        return res;
    }
}
