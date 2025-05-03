// See https://aka.ms/new-console-template for more information
using System;
namespace CursoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch con opciones de tipo caracter
            Console.WriteLine("Elige una de las opciones: ");
            Console.WriteLine("a) Imprimir Hola Mundo ");
            Console.WriteLine("b) Imprimir suma de dos numeros ");
            Console.WriteLine("c) Imprimir nada");
            char opcion =Convert.ToChar(Console.ReadLine());
            switch(opcion)
            {
                case 'a': Console.WriteLine("Hola Mundo");
                    break;
                case 'b':
                    int num1 = 3;
                    int num2 = 7;
                    int resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 'c': Console.WriteLine("nada");
                    break;
                default: Console.WriteLine("No se selecciono ninguna de las opciones");
                    break ;
            };
            /*
            //numeros aleatorios
            Random random = new Random();

            int numerorandom = random.Next(0, 10000);
            Console.WriteLine(numerorandom);
            double numdecimalesrandom = random.NextDouble();
            Console.WriteLine(numdecimalesrandom);
            Console.WriteLine(numerorandom+ numdecimalesrandom);
            
             * 
            //operadores logico
            int num1 = 5;
            int num2 = 4;
            if(num1 == 5 || num2 ==7)
            {
                Console.WriteLine("Las condiciones son verdaderas");
            }
            else
            {
                Console.WriteLine("Las condiciones son falsas");
            }

            //not
            bool opcion = true;
            if(!opcion)
            {
                Console.WriteLine("La opcion es falsa");
            }
            else
            {
                Console.WriteLine("La opcion es verdadera");
            }
            
            //codigo principal
            int num = 5;
            int num2 = 46;
            int numero = 74;
            decimal dec = (decimal)10.2;
            string  hola= "hola";
            string texto1 = "curso de programacion";

            Console.WriteLine("Codigo principal");
            FuncionPorValor(num, numero, dec);
            Console.WriteLine("Funcion principal "+num);
            Console.WriteLine("\n-------------------------------\n");
            FuncionPorRef(ref num, hola, ref texto1);
            Console.WriteLine("Funcion principal " + num);
            */


        }
        /*
        static void Saludar(string nombre)
        {
            //Codigo que se ejecuta esta funcion
            Console.WriteLine("Hola usuario");
        }
        static void FuncionPorValor(int num, int numero, decimal dec)
        {
            num = num * 2;
            Console.WriteLine("Valor de num dentro de la funcion por valor " + num+ " "+ numero+ " "+ dec);
        }
        static int Devolvernumero()
        {
            //funcion que regresa un numero
            int num1 = 2;
            int num2 = 9;
            int resultado = num1 + num2;
            return resultado;
        }
        static void FuncionPorRef(ref int num, string hola, ref string texto1)
        {
            num = num * 2;
            Console.WriteLine("Valor de num dentro de la funcion por referencia " + num+ " "+hola+" "+texto1);
        }
        */


    }
    
}

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
Console.WriteLine("El resultado de la suma es: "+resultado_suma);

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
}*/
