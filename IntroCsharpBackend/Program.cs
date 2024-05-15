

/* Primera forma de crear */
Sale sale = new Sale(10);
// sale.Total = 15;

/* Segunda Forma de crear */
var sale2 = new Sale(10); // Azucar sintáctica

/* Tercera forma de crear y es medio nueva */
Sale sale3 = new(10);


var message = sale.GetInfo(); // recupera el texto
Console.WriteLine(message);


// Herencia
// Tambien hereda métodos
var sale4 = new SaleWithTax(10, 0.1m);
var message2 = sale4.GetData(); // se ejecuto el getdata del hijo y no del padre
Console.WriteLine(message2);
// Si GetInfo fuera privado, solo podría usarlo la clase Sale, las clases que hereden de Sale no podrían usarlo.
// Si GetInfo fuera protected, podría acceder desde dentro de Sale y las clases que hereden como SaleWithTax, pero no se podría acceder desde fuera de las clases.

class Sale { 
    public decimal Total { get; set; } // publica, se que se puede acceder desde afuera
    private decimal _some; // por lo general se pone _ guión bajo en las variables privadas 

    // Constructur donde puedes o no inicializar
    public Sale(decimal total) { 
        this.Total = total; // Total = total; otra forma es sin el this porque son diferentes
        this._some = 8; // some solo se puede acceder dentro del scope
    }

    // Método o funcion que retorno un string
    public string GetInfo() 
    {
        return "El Total es " + Total;
    }
    public virtual string GetData()
    {
        return "Esto retorna una data en la clase padre llamada Sale";
    }
}

// Herencia
class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total) // Al heredar de Sale tiene un constructuro que tiene que inicializar, entonces le mandamos un valor
    {
        this.Tax = tax;
    }
    public string GetInfoWithTax()
    {
        return "El Total es " + Total + " más impuestos es " + Tax;
    }


    // La clase padre debe tener Virtual y la clase hijo override para sobreescribir la funcion
    public override string GetData()
    {
        return "Esto sobrescribe la función GetData del padre, para eso necesitas el padre con virtual y el hijo con override";
    }
}