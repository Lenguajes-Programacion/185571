using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO; 
using System.Text;

namespace proyecto2v2
{
    class Memoria
    {
        //Creamos una lista nativa para el manejo de la momeria 
        public List<MemoriaData> db = new list<MemoriaData>();
        public Memoria()
        {
            //contructor de clase Memoria, para inicializar listas 
            db = new List<MemoriaData>();
        }
        public void LeerMemoria()
        {
            ConsoleColor currentColor = Console.BackgroundColor;
            string archivoDB = "../../../db.json"; //Es la ubicación del archivo
            StreamReader reader = new StreamReader(archivoDB); //es para que lea en tiempo real el archivo 
            var dbJSON = reader.ReadToEnd();
            var dbObjet = JObject.parse(dbJSON);
            int i = 0; //Agregamos un contador 
            foreach ((var key, var item) in dbObjet)
            {
                MemoriaData memoriaData = new MemoriaData(i, item.key.ToString(), item.Value["operacion"].toString(), item.value["resultado"].toString());
                this.db.add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(), memoriaData.fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        public int GetMemoriaData(String key)
        {
            //Encontrar datos con un indice manual. 
            int index = int.Parse(key);
            MemoriaData data = db[index];
            return data.resultado;
        }
    }
    class MemoriaData
    {
        public int key;
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(int i, String date, String operation, String result)
        {
            key = i;
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
    } 
}
    class MemoriaData
    {
        public DateTime fecha;
        public string operacion;
        public int resultado;
        public MemoriaData(DateTime date, String operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result; 
        }
    }
}
