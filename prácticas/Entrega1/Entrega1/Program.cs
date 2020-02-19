using System;
// Entrega 100
namespace Entrega1
{
    class menu
    {
        static void Main(string[] args)
        {
            string des;
            while(true) {
                Console.WriteLine("Eliga que desea hacer");
                Console.WriteLine("1. Práctica args");
                Console.WriteLine("2. Calculadora");
                des = Console.ReadLine();
                switch (des)
                {
                    case "1":
                        comprobacion nombre = new comprobacion();
                        comprobacion.check();
                        break;
                    case "2":
                        calculadora Noperaciones = new calculadora();
                        calculadora.operaciones(args); 
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
            }

        }
    }
    class comprobacion 
    {
        static string nombre = "Abigail";
        public static void check()
        {
            string usuario;
            Console.WriteLine("Ingrese el nombre del usuario");
            usuario = Console.ReadLine();
            if (usuario.Length > 0 && usuario == nombre)
            {
                Console.WriteLine($"Hola {usuario}");
            }
            else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
    class calculadora
    {
        public static void operaciones(string[] args)
        {
            string salir = null;
            string resp = null;
            int v1, v2, r;
            float division;
            string opc;
            do
            {
                Console.WriteLine("Elige que operación realizar");
                Console.WriteLine("(+)...Suma");
                Console.WriteLine("(-)...Resta");
                Console.WriteLine("(*)...Multiplicar");
                Console.WriteLine("(/)...Dividir");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "+":
                        Console.WriteLine("se eligió una suma");
                        Console.WriteLine("Ingresa el primer número");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        v2 = int.Parse(Console.ReadLine());
                        r = v1 + v2;
                        Console.WriteLine("El resultado es" + r);
                        Console.WriteLine("¿Quiere utilizar el resultado anterior?(si)(no)");
                        resp = Console.ReadLine();
                        if (resp == "no")
                        {
                            break;
                        }
                        Console.WriteLine("ingresa el valor a sumar");
                        v1 = int.Parse(Console.ReadLine());
                        r = v1 + r;
                        Console.WriteLine("el resultado es: " + r);
                        break;
                    case "-":
                        Console.WriteLine("Se eligió una resta");
                        Console.WriteLine("ingresa el primer numero");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        v2 = int.Parse(Console.ReadLine());
                        r = v1 - v2;
                        Console.WriteLine("el resultado es: " + r);
                        Console.WriteLine("¿quiere utilizar el resultado anterior?");
                        resp = Console.ReadLine();
                        if (resp == "no")
                        {
                            break;
                        }
                        Console.WriteLine("ingresa el valor a restar");
                        v1 = int.Parse(Console.ReadLine());
                        r = v1 - r;
                        Console.WriteLine("El resultado es: " + r);
                        break;
                    case "*":
                        Console.WriteLine("Eligió multiplicar");
                        Console.WriteLine("ingresa el primer numero");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        v2 = int.Parse(Console.ReadLine());
                        r = v1 * v2;
                        Console.WriteLine("El resultado es: " + r);
                        Console.WriteLine("¿Quiere utilizar el resultado anterior?");
                        resp = Console.ReadLine();
                        if (resp == "no")
                        {
                            break;
                        }
                        Console.WriteLine("ingresa el valor a multiplicar");
                        v1 = int.Parse(Console.ReadLine());
                        r = v1 * r;
                        Console.WriteLine("El resultado es: " + r);
                        break;
                    case "/":
                        Console.WriteLine("Eligió dividir");
                        Console.WriteLine("ingresa el primer numero");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        v2 = int.Parse(Console.ReadLine());
                        division = v1 / v2;
                        Console.WriteLine("El resultado es" + division);
                        Console.WriteLine("Desea utilizar el resultado anterior?");
                        resp = Console.ReadLine();
                        if (resp == "no")
                        {
                            break;
                        }
                        Console.WriteLine("ingresa el valor a dividir");
                        v1 = int.Parse(Console.ReadLine());
                        division = v1 / division;
                        Console.WriteLine("El resultado es: " + division);
                        break;
                }
                Console.WriteLine("¿Desea volver a usar la calculadora?(si)(no)");
                salir = Console.ReadLine();
            } while (salir == "si");
            if (salir == "no")
            {
                Console.WriteLine("Elegiste salir de la calculadora");
            }
            Console.ReadKey();
        }
    }
}

