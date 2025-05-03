// See https://aka.ms/new-console-template for more information
string texto1 = "Hola";
string texto2 = "hola";
if (texto1 == texto2)
{
    Console.WriteLine("Texto 1 es igual que texto 2");
}
else
{
    Console.WriteLine("Texto 1 es diferente que texto 2");
}
if (texto1.Equals(texto2))
{
    Console.WriteLine("Texto 1 es igual que texto 2");
}
else
{
    Console.WriteLine("Texto 1 es diferente que texto 2");
}

char caracter1 = 'a';
char caracter2 = 'a';
if (caracter1 == caracter2)
{
    Console.WriteLine("Caracter1 es igual a caracter2");
}
else
{
    Console.WriteLine("Caracter2 es diferente a caracter2");
}