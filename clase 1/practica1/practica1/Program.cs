using system;
//libreria principal

namespace practica1
{
    class program //program es una clase base
    {
        static string nombre = "Abigail"; //Declaración de una variable 

        static void Main(string[] args) //args = Es un argumento, siempre van entre comillas ""
        {
            Console.WriteLine($"Hello {args[0]} {args[1]}");
        }
    }
}
