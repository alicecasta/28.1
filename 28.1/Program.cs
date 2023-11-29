using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone studente = new Persone();
            Console.WriteLine( "inserire dati sullo studente:");
            Console.WriteLine("nome: ");
            studente.Nome = Console.ReadLine();
            Console.WriteLine("cognome: ");
            studente.Cognome = Console.ReadLine();
            Console.WriteLine("data di nascita: ");
            studente.Nascita = DateTime.Parse(Console.ReadLine());
            int giorno = studente.Nascita.Day;
            int mese= studente.Nascita.Month;
            int anno= studente.Nascita.Year;
            Console.WriteLine("la data del voto: ");
            studente.Data = DateTime.Parse(Console.ReadLine());
            int giorno1 = studente.Data.Day;
            int mese1 = studente.Data.Month;
            int anno1 = studente.Data.Year;
            Console.WriteLine("il voto: ");
            studente.Voto = int.Parse(Console.ReadLine());
            Console.WriteLine("la materia: ");
            studente.Materia = Console.ReadLine();
            

            Console.WriteLine("inserire dati sull'insegnante: ");
            Persone insegnante= new Persone();
            Console.WriteLine("nome: ");
            insegnante.Nome = Console.ReadLine();
            Console.WriteLine("cognome: ");
            insegnante.Cognome = Console.ReadLine();
            Console.WriteLine("data di nascita: ");
            insegnante.Nascita = DateTime.Parse(Console.ReadLine());
            int giorno2 = studente.Nascita.Day;
            int mese2 = studente.Nascita.Month;
            int anno2 = studente.Nascita.Year;
            Console.WriteLine("materia che insegna: ");
            insegnante.Materia= Console.ReadLine();
            Console.WriteLine("sigla: ");
            insegnante.Sigla= Console.ReadLine();

            Console.WriteLine("studente:{0} {1} nato il {2}/{3}/{4}. Il giorno {5}/{6}/{7} ha peso {8} in {9}", studente.Nome, studente.Cognome, giorno, mese, anno, giorno1, mese1, anno1, studente.Voto, studente.Materia);
            Console.WriteLine("insegnante:{0} {1} nato il {2}/{3}/{4}, insegna {5}, la sigla è {6}.",insegnante.Nome, insegnante.Cognome, giorno, mese, anno, insegnante.Materia, insegnante.Sigla);


           Console.ReadLine();
        }

    }
}
