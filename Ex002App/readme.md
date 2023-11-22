Отношение между классами: ассоциация, композиция и агрегация
[url](https://habr.com/ru/articles/354046/)

Логика работы с компаратором `IComparable<UserContact>`

```c#
List<UserContact> db = new();
UserContactCreator userContactCreator = new();

for (int i = 0; i < 3; i++)
{
  db.Add((UserContact)userContactCreator.GetContact());
  Console.WriteLine(db[i]);
}

db.Sort();
System.Console.WriteLine();
for (int i = 0; i < db.Count; i++)
{
  Console.WriteLine(db[i]);
}
```

```c#
System.Collections.Generic.List
System.Collections.Generic.HashSet
System.Collections.Generic.Dictionary
System.Collections.Generic.Stack
System.Collections.Generic.Queue
```
Логика работы со сравнением `IEquatable<UserContact>`

```c#
UserContact user1 = new UserContact();
user1.FirstName = "No Name";
user1.LastName = "LastName";

UserContact user2 = new UserContact();
user2.FirstName = "No Name";
user2.LastName = "LastName";

List<UserContact> db = new();
UserContactCreator userContactCreator = new();
db.Add(user1);
for (int i = 0; i < 3; i++)
{
  db.Add((UserContact)userContactCreator.GetContact());
}

System.Console.WriteLine(db.IndexOf(user2));

```
