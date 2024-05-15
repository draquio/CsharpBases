// genéricos, el estandar para genéricos es T, se usa T cuando no sabes que tipo de dato usaremos

public class MyList<T>
{
    private List<T> _list;
    private int _limit;
    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }
    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }
    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ", ";
        }
        return content;
    }
}

public class Beer // : object Todas las clases si o si heredan de object por defecto 
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public override string ToString() // sobreescribe cuando lista en el método
    {
        return Name + ": " + Price + "$";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new MyList<int>(5);
        var names = new MyList<string>(5);
        var beers = new MyList<Beer>(3);
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        
        names.Add("Lorena");
        names.Add("Fernando");
        names.Add("Luis");
        names.Add("Antonio");
        names.Add("Alejandra");
        names.Add("Rosario");
        names.Add("Noel");

        beers.Add(new Beer()
        {
            Name = "Erdinger",
            Price = 5
        });
        beers.Add(new Beer()
        {
            Name = "Delirium",
            Price = 15
        });
        beers.Add(new Beer()
        {
            Name = "Corona",
            Price = 1
        });
        beers.Add(new Beer()
        {
            Name = "Paulaner",
            Price = 5
        });

        Console.WriteLine(names.GetContent());
        Console.WriteLine(numbers.GetContent());
        Console.WriteLine(beers.GetContent());
    }

}