class Program
{
    static void Main(string[] args)
    {
        Node n0 = new("Анна", Gender.Female);
        Node n1 = new("Сергей", Gender.Male);
        Node n2 = new("Илья", Gender.Male);         n2.SetParent(n0).SetParent(n1);
        Node n3 = new("Тимофей", Gender.Male);      n3.SetParent(n0).SetParent(n1);
        Node n4 = new("Тамара", Gender.Female); 
        Node n5 = new("Виктор", Gender.Male);       n1.SetParent(n4).SetParent(n5);
        Node n6 = new("Олег", Gender.Male);         n6.SetParent(n4).SetParent(n5);
        Node n7 = new("Елена", Gender.Female);
        Node n8 = new("Роман", Gender.Male);        n8.SetParent(n6).SetParent(n7);
        Node n9 = new("Антон", Gender.Male);        n9.SetParent(n6).SetParent(n7);
        Node n10 = new("Владимир", Gender.Male);
        Node n11 = new("Нина", Gender.Female);      n0.SetParent(n10).SetParent(n11);
        Node n12 = new("Константин", Gender.Male);  n12.SetParent(n10).SetParent(n11);
        Node n13 = new("Ирина", Gender.Female);
        Node n14 = new("Дарья", Gender.Female);     n14.SetParent(n12).SetParent(n13);
        Node n15 = new("Кира", Gender.Female);      n15.SetParent(n12).SetParent(n13);

        
        Console.WriteLine(n15.Gen);
    }
}

public enum Gender
{
    Male, Female
}

public class Node
{
    public Node(string name, Gender gen) 
    {
        this.Name = name;
        this.Gen = gen;
        Childs = new();
        parent = new();
    }
    public string Name {get;}
    public Gender Gen {get;}

    private Dictionary<Gender, Node> parent;
    public Node Father { get => parent.GetValueOrDefault(Gender.Male); }
    public Node Mother { get => parent.GetValueOrDefault(Gender.Female); }
    public List<Node> Childs {get;}

    public Node SetParent(Node n)
    {
        if (parent.GetValueOrDefault(n.Gen) != null)
            throw new Exception("Повторное определение родителя!!!");
        parent.Add(n.Gen, n);
        n.Childs.Add(this);
        return this;
    }
}
