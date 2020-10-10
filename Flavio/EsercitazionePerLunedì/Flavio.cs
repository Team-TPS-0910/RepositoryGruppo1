using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsercitazionePerLunedì;

namespace EsercitazionePerLunedì
{
    public class Flavio
    {
        public string Nome{get; set;}
        public string Cognome { get; set; }
        public static void Flev()
        {
            Console.WriteLine("flavio Gavarini");
        }
        public static void Persona(Flavio flavio)
        {
            
            Console.WriteLine(flavio.Nome +" "+flavio.Cognome);
        }           
    }
}
