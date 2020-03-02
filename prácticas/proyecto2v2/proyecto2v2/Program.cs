using System;

namespace proyecto2v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = null;
            string resp = null;
            int v1, v2, r;
            float division;
            string opc;
            do
            {
                Console.WriteLine("Eligue que operación realizar");
                Console.WriteLine("(+)...Suma");
                Console.WriteLine("(-)...Resta");
                Console.WriteLine("(*)...Multiplicar");
                Console.WriteLine("(/)...Dividir");
                Console.WriteLine("(m)... memoría"); 
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
                        Console.WriteLine("Eligioi multiplicar");
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
                    case "m":
                        Console.WriteLine("Accediendo a Memoria \n");
                        Console.WriteLine("-----------------\n");
                        Memoria memoria = new Memoria();
                        memoria.LeerMemoria();
                        String key = Console.ReadLine();
                         int resultado = memoria.GetMemoriaData(key);
                        Console.WriteLine(resultado);
                        memoria.GuardarMemoria();
                        break;
                }
                Console.WriteLine("¿Desea volver a usar la calculadora?(si)(no)");
                salir = Console.ReadLine();
            } while (salir == "si");
            if (salir == "no")
            {
                Console.WriteLine("Eleguiste salir de la calculadora");
            }
            Console.ReadKey();
        }
    }
}

