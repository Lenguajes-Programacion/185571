using System;

namespace practicaUno
{
    class Program
    {
        static string nombre = "Abigail";
        static void Main(string[] args)
        {
            if (args[0].Length > 0 && args[0] == nombre)//es un dato booleano true or false
            {
                //"&&" Condición and 
                //Condición or "||"
                //Tipos de comparación:">" Mayor "<" Menos "=="Igual ">="Mayor igual "<="Menor igual "!="Diferente que "!"
                Console.WriteLine($"Hello {args[0]}  {args[1]}");
            }
            else //es un sino 
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}