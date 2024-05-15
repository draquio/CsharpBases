// Las expresiones Lambda en otros lenguajes se las conoce como arrow function o funciones de flecha

Func<int, int, int> sub = (a, b) => a - b;
// funcion que recibe 2 ints y retorna un int, variables de entrada a y  b => hace un a - b y retorna el valor

// Es lo mismo que estas funciones
int sub2(int a, int b) => a - b;

int sub3(int a, int b)
{
    return a - b; 
}

// Las 3 funciones hacen lo mismo pero está expresadas de diferente manera
// la funcion que se declara como Func es declarada como variable y no como funcion
Console.WriteLine(sub(2,1));
Console.WriteLine(sub2(4,2));
Console.WriteLine(sub3(6,3));


// Mas corta
// function action que multiplica a * 2, no se necesita (a) => a * 2, se quita el parentesis
Func<int, int> mult = a => a * 2;
// Func<int, int> mult = a => { return a * 2}; Es lo mismo
Console.WriteLine(mult(2));

// Se puede enviar una expresion lambda como funcion
Some((a, b) => a + b, 5); // Resultado 10
void Some(Func<int, int, int> fn, int number)
{
    var result = fn(number, number);
}