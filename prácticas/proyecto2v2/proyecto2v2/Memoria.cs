using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO; 
using System.Text;

namespace proyecto2v2
{
    class Memoria
    {
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json"; //Es la ubicación del archivo
            StreamReader reader = new StreamReader(archivoDB); //es para que lea en tiempo real el archivo 
            var dbJSON = reader.ReadToEnd();
            var dbObjet = JObject.parse(dbJSON); 
            foreach ((var key, var item) in dbObjet)
            {
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(), (int)item["resultado"]);
                Console.WriteLine(key.ToString());
                Console.WriteLine(MemoriaData.resultado.ToString()); 
            }
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public string operacion;
        public int resultado; 
        public MemoriaData (DateTime date )
    }
}
