// See https://aka.ms/new-console-template for more information
/*int numero = 1;

while(numero <5)
{
    //El codigo que este aqui se va a ejecturar mientras la condicion del ciclo se cumpla
    Console.WriteLine(numero + "antes de la suma");
    numero = numero + 1;
    Console.WriteLine(numero + "despues de la suma");
}
do
{
    numero+=1;
    Console.WriteLine(numero);
} while (numero < 3);
for (int cont = 0; cont <5; cont++)
{
    Console.WriteLine(cont);
}

//lectura de datos
string nombre = "";
Console.WriteLine("Por favor inserta tu nombre");
nombre = Console.ReadLine();
Console.WriteLine("\n Tu nombre es: " + nombre);
Console.WriteLine("\nIngresa el primer numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n El numero es: " + num1);
Console.WriteLine("\nIngresa el segundo numero: ");
int num2 = 0;
string textonum2 = "";
textonum2 = Console.ReadLine();
num2 = Convert.ToInt32(textonum2);
int resultado_suma = num1 + num2;
Console.WriteLine("El resultado de la suma es: "+resultado_suma);*/

//areglos
int[] arreglo1 = new int[4];
Console.WriteLine(arreglo1.Length);
arreglo1[0] = 12;
arreglo1[1] = 23;
arreglo1[2] = 84;
arreglo1[3] = 40;
for (int cont = 0; cont < arreglo1.Length; cont++)
{
    Console.WriteLine(arreglo1[cont]);
}
