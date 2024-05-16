// Linq son consultas, algo asi como SQL


var names = new List<string>()
{
    "Sergio", "Luis", "Alejandra", "Celeste", "Lorena"
};

// var namesResult = from n in names orderby n select n; // a lado de orderby n descending para que sea desendente
var namesResult = from n in names where n.Length > 6 orderby n select n;
// Otra forma de hacerlo es con expresiones lambda o arrow function
var nameResults2 = names.Where(n => n.Length > 6).OrderByDescending(n => n).Select(d => d);

foreach (var name in nameResults2)
{
    Console.WriteLine(name);
}