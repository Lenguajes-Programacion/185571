using System;
//calculadora //tarea, operaciones basicas 
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
            Console.Title = "MiniCalculadora";
            Console.WriteLine("Calculadora");
            int v1 = 0, v2 = 0, R = 0;
            Console.WriteLine("Eliga una opcion");
            resp = Console.ReadLine(); 
              
            switch (args[1])
            {
                case "+":
                    Console.WriteLine("Eligío sumar");
                    R = v1 + v2;
                    Console.WriteLine("{0} + {1}= {2}", v1, v2, R); 
                        break;
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido" + args[1]);
                    break;
            }
        }
    }
}
