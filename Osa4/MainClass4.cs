using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa4
{
    internal class MainClass4 : FunktsioonidOsa4
    {
        public static void Main(string[] args)
        {

            List<string> kuude_list = new List<string>();

            Console.WriteLine("4osa.C# Failitöötlus klassis");


            // Faili kirjutamine(StreamWriter)
            try
            {
                FunktsioonidOsa4.FailiKirjutamine();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }


            // Faili lugemine (StreamReader)
            try
            {
                FunktsioonidOsa4.FailiLugemine();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }


            // Ridade lugemine List<string> abil
            try
            {
                FunktsioonidOsa4.RidadeLugemine();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }


            // Listi muutmine ja kuvamine
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            kuude_list.Remove("Juuni");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime Juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }



            // Otsing nimekirjast
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");


            // Listi salvestamine tagasi faili
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }
    }
}
