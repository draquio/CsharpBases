


public class Beer
{
    public string Name { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var beer = new Beer()
        {
            Name = "guinness"
        };
        Console.WriteLine(ToUpper(beer).Name);
        Console.WriteLine(beer.Name);
        // En la funcion al crear un nuevo objeto que toma los valores y retornar este,
        // el valor original no muta, de esa manera tenemos el valor original y un nuevo valor
        Beer ToUpper(Beer beer)
        {
            var beer2 = new Beer()
            {
                Name = beer.Name.ToUpper(),
            };
            return beer2;
        }

        // Se puede almacenar una funcion en una variable y luego ejecutar la variable
        var show = Show;
        show("hola");
        void Show(string message)
        {
            Console.WriteLine(message);
        }

        // El tipo de funcion Action es aquella funcion que ejecuta pero no retorna nada ejemplo => Void
        Some(show, "Hola desde el medio");
        // Estamos enviando una funcion del tipo string para que se ejecute mientras otras cosas se ejecutan
        void Some(Action<string> fn, string message)
        {
            Console.WriteLine("Hace algo al inicio");
            fn(message);
            Console.WriteLine("Hace algo al final");
        }

        // void Some(Func<string, string> fn, string, message) => Func es una funcion que si retorna algo <valor de entrada, valor de salida>
        // el ultimo (en este caso string) siempre será el valor que retornará,
        // ejemplo = Func<string, int, decimal, string> => la salida es un string



    }
}
