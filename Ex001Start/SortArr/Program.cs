Console.Write("Введите количество элементов в массиве: ");
int len = int.Parse(Console.ReadLine());

var arr = new int[len];

for(int i = 0; i < len; i++)
{
    arr[i] = Random.Shared.Next(100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

// Сортировка массива
for(int k = 1; k < len; k++)
{
    for(int i = k; i > 0; i--)
    {
        if (arr[i] < arr[i - 1])
        {
            int tmp = arr[i - 1];
            arr[i - 1] = arr[i];
            arr[i] = tmp;
        }
        else
        {
            break;
        }
    }
}

for(int i = 0; i < len; i++)
{
    Console.Write(arr[i] + " ");
}