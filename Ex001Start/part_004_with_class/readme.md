# Декомпозиция задачи
Создать массив целых чисел, заполнить его числами и распечатать на экран.

- [x] Считывания данных от пользователя
- [x] Создания массива
- Печать массива
  - [x] в терминал
  - [ ] в файл
- Заполнение массива
  - [x] случайно
  - [ ] от пользователя
  - [ ] из файла


# Методы

### Описание метода
```
int, double, UserType, void
ВозвращаемыйТипМетода ИмяМетода(формальные аргументы)
{
  /// Тело метода

  return; // если void
  return значение; // если не void
}
```
Пример: сложение двух целых чисел

```
int Sum(int x, int y)
{
  int result;
  result = x + y;

  return result;
}
```
### Вызов метода
- не void-метод

```
ИмяМетода(фактические аргументы);
```
```
ТипПеременнойАналогичныйВозвращаемомуТипМетода переменная = ИмяМетода(фактические аргументы);
```
- void-метод

```
ИмяМетода(фактические аргументы);
```

Пример:
```
Sum(1, 2);
```
```
int value1 = 123;
int value2 = 321;
int add = Sum(value1, value2);
```
```
int add = Sum(x: value1, y: value2);
```
```
int add = Sum(y: value2, x: value1);
```

# Массивы
## Одномерные

- `ТипДанных[] имя;` -> `int[] numbers;`
- `имя = new ТипДанных[количество];` -> `numbers = new int[10];`
- `ТипДанных[] имя = new ТипДанных[количество];`

`Array.Resize(ref имяМассива, новоеКоличество);`

## Значения по умолчанию
[Значения по умолчанию типов C# (справка по C#)](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/default-values)

## Многомерные
### Двумерные
`int[,] array = new int[rows, columns];`

### Четырёхмерные

`int[,,,] array = new int[length1, length2, length3,length5];`

### Массив массивов
```
int[][] array = new int[4][];
array[0] = new int[4];
array[1] = new int[4];
array[2] = new int[4];
array[3] = new int[4];
```

```
int[][] array = new int[4][];
array[0] = new int[3];
array[1] = new int[2];
array[2] = new int[5];
array[3] = new int[1];
```