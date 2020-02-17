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
            int v1, v2, r;
            switch
            {
                case "+":
                Console.WriteLine("Eligío sumar");
                Console.WriteLine("Ingrese el primer número: ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                v2 = int.Parse(Console.ReadLine());
                r = v1 + v2;
                Console.WriteLine("El resultados es: " + r);
                 break;
                  case "-":
                Console.WriteLine("Eligío restar");
                Console.WriteLine("Ingrese el primer número: ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                v2 = int.Parse(Console.ReadLine());
                r = v1 - v2;
                Console.WriteLine("El resultados es: " + r);
                break; 
                  case "*":
                Console.WriteLine("Eligío multiplicar");
                Console.WriteLine("Ingrese el primer número: ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                v2 = int.Parse(Console.ReadLine());
                r = v1 * v2;
                Console.WriteLine("El resultados es: " + r);
                break;
                    float v2; 
                 case "%":
                Console.WriteLine("Eligío dividir");
                Console.WriteLine("Ingrese el primer número: ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                v2 = int.Parse(Console.ReadLine());
                r = v1 /v2;    
                Console.WriteLine("El resultados es: " + r);
                break; 
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido" + args[1]);
                    break;
            }
        }
    }
}
