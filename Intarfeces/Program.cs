// La interfaz es básicamente tipar 
// La interface obliga a tener los atributos y métodos en la clase que usa esta interface

interface IVenta
{
    decimal Total { get; set; }
}
interface IGuardar
{
    public void Guardar();
}


public class Venta : IVenta, IGuardar
{
    public decimal Total { get; set; }
    public void Guardar()
    {
        Console.WriteLine("Guardado");
    }
}


public class Beer : IGuardar
{
    public void Guardar()
    {
        Console.WriteLine("Cerveza guardado");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var beer = new Beer();
        var Venta = new Venta();
        Some(beer);
        Some(Venta);

        void Some(IGuardar objeto)
        {
            objeto.Guardar();
        }
    }

}