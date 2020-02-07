using System;
//calculadora 
//Se reciben dos argumentos valor1 (int), valor2 (string) operador
//valor3 (int)
//responde el resultado (int)
//se busca siempre darle una respuesta al usuario, siendo interactivo. 
namespace ProyeyctoDos
{
    static class Program
    {
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "+":
                    Console.WriteLine("Es una suma");
                    break;
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido" + args[1]);
                    break;
            }
        }
    }
}
