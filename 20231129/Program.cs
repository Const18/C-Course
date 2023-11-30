class Program
{
    static void Main(string[] args)
    {
        Person n0 = new("Анна", Gender.Female);
        Person n1 = new("Сергей", Gender.Male);
        n1.Marriage(n0);
        Person n2 = new("Илья", Gender.Male);
        n2.SetParent(n0).SetParent(n1);
        Person n3 = new("Тимофей", Gender.Male);
        n3.SetParent(n0).SetParent(n1);
        Person n4 = new("Тамара", Gender.Female);
        Person n5 = new("Виктор", Gender.Male);
        n4.Marriage(n5);
        n1.SetParent(n4).SetParent(n5);
        Person n6 = new("Олег", Gender.Male);
        n6.SetParent(n4).SetParent(n5);
        Person n7 = new("Елена", Gender.Female);
        n7.Marriage(n6);
        Person n8 = new("Роман", Gender.Male);
        n8.SetParent(n6).SetParent(n7);
        Person n9 = new("Антон", Gender.Male);
        n9.SetParent(n6).SetParent(n7);
        Person n10 = new("Владимир", Gender.Male);
        Person n11 = new("Нина", Gender.Female);
        n11.Marriage(n10);
        n0.SetParent(n10).SetParent(n11);
        Person n12 = new("Константин", Gender.Male);
        n12.SetParent(n10).SetParent(n11);
        Person n13 = new("Ирина", Gender.Female);
        n12.Marriage(n13);
        Person n14 = new("Дарья", Gender.Female);
        n14.SetParent(n12).SetParent(n13);
        Person n15 = new("Кира", Gender.Female);
        n15.SetParent(n12).SetParent(n13);
        
        // Console.WriteLine(n15.Gen);
        HashSet<Person> l = new() {n15, n0};
        l.Fathers().Print();
    }
}

public enum Gender
{
    Male, Female
}

public class Person
{
    public Person(string name, Gender gen) 
    {
        this.Name = name;
        this.Gen = gen;
        Childs = new();
        parent = new();
    }
    public string Name {get;}
    public Gender Gen {get;}

    private Dictionary<Gender, Person> parent;
    public Dictionary<Gender, Person>.ValueCollection Parents { get => parent.Values; }
    public Person Father { get => parent.GetValueOrDefault(Gender.Male); }
    public Person Mother { get => parent.GetValueOrDefault(Gender.Female); }
    public List<Person> Childs {get;}
    private Person spouse;
    public Person Spouse { get => spouse; }

    public Person SetParent(Person n)
    {
        if (parent.GetValueOrDefault(n.Gen) != null)
            throw new FamilyTreeMultipleParentDefinitionException(this, parent.GetValueOrDefault(n.Gen), n);
        parent.Add(n.Gen, n);
        n.Childs.Add(this);
        return this;
    }
    public void Marriage(Person n)
    {
        if (spouse != null)
            throw new FamilyTreePolygamyException(this, spouse, n);
        if (n.spouse != null)
            throw new FamilyTreePolygamyException(n, n.spouse, this);
        if (n.Gen == this.Gen)
            throw new FamilyTreeGayMarriageException(this, n);
        spouse = n;
        n.spouse = this;
    }
}

/*
    "Отец" : Father, *
    "Мать" : Mather, *
    "Родители" : Parent.Values[], *

    "Муж" : Spouse, Male
    "Жена" : Spouse, Female
    "Супруг" : Spouse, *

    "Сыновья" : Childs[], Male
    "Дочери" " Childs[], Female
    "Дети" : Childs[], *

    "Дедушка" : "Родители" --> "Отец"
    "Бабушка" : "Родители" --> "Мать"
    "Внуки" : "Дети" --> "Дети"
    "Брат" : "Родители" --> ("Сыновья" - this)
    "Шурин" : "Жена" --> "Брат"
*/
static class Relashinship
{
    public static HashSet<Person> Fathers(this HashSet<Person> lst)
    {
        HashSet<Person> result = new();
        foreach (var item in lst)
        {
            if (item.Father != null) result.Add(item.Father);
        }
        return result;
    }

    public static void Print(this HashSet<Person> lst)
    {
        foreach (var item in lst)
        {
            Console.WriteLine(item.Name);
        }
    }
}

public class FamilyTreeException : Exception
{
    public FamilyTreeException(string message) : base(message) { }
}
public class FamilyTreeMultipleParentDefinitionException : FamilyTreeException
{
    public FamilyTreeMultipleParentDefinitionException(Person child, Person parent, Person parentExtra) :
        base($"Множественное определение родителя (ребёнок - {child.Name}, родитель - {parent.Name}, добавляемый родитель - {parentExtra.Name})!!!") { }
}
public class FamilyTreePolygamyException : FamilyTreeException
{
    public FamilyTreePolygamyException(Person p1, Person p2, Person pExtra) :
        base($"Многоженство в РФ запрещено (добавление {pExtra.Name} к браку {p1.Name} + {p2.Name})!!!") { }
}
public class FamilyTreeGayMarriageException : FamilyTreeException
{
    public FamilyTreeGayMarriageException(Person p1, Person p2) : 
        base($"Однополые браки в РФ запрещены ({p1.Name} + {p2.Name})!!!") { }
}
