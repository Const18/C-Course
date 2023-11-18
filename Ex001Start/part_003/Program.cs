Console.Clear(); // Очистка консоли
Console.CursorVisible = false;
// Console.SetCursorPosition(left, top); // установка курсора в нужную позицию

int left1 = 30;
int top1 = 1;
Console.SetCursorPosition(left1, top1);
Console.WriteLine("+");

int left2 = 2;
int top2 = 20;
Console.SetCursorPosition(left2, top2);
Console.WriteLine("+");

int left3 = 60;
int top3 = 20;
Console.SetCursorPosition(left3, top3);
Console.WriteLine("+");

int left = (left1 + left2) / 2;
int top = (top1 + top2) / 2;

int count = 2000;
int step = 0;

while (step < count)
{
  int random = Random.Shared.Next(3) + 1; // 1 2 3

  if (random == 1)
  {
    left = (left + left1) / 2;
    top = (top + top1) / 2;
  }

  if (random == 2)
  {
    left = (left + left2) / 2;
    top = (top + top2) / 2;
  }

  if (random == 3)
  {
    left = (left + left3) / 2;
    top = (top + top3) / 2;
  }
  Console.SetCursorPosition(left, top);
  Console.WriteLine("+");
  step++;
}

Console.ReadLine();