using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.KangelaneOsa
{
    internal class KangelaneClass
    {
        // Статическое поле для хранения всех созданных героев
        private static List<Kangelane> kangelased = new List<Kangelane>();

        static void Main(string[] args)
        {
            Console.WriteLine("Ülesanne: Kangelaste agentuuri infosüsteem/1. Klass: Kangelane");
            Kangelane kangelane = new Kangelane("Sam", "Shire");

            Console.WriteLine(kangelane.ToString());
            Console.WriteLine(kangelane.Tervitus());
            Console.WriteLine($"Riietus: {kangelane.Vormiriietus()}");
            Console.WriteLine($"Staatus: {kangelane.MissiooniStaatus()}");

            int ohustatud = 100;
            int paastetud = kangelane.Paasta(ohustatud);
            Console.WriteLine($"Päästitud inimesi: {paastetud}/{ohustatud}");

            Console.WriteLine("-------");

            Console.WriteLine("Ülesanne: Kangelaste agentuuri infosüsteem/2. Klass: SuperKangelane");
            Superkangelane superKangelane = new Superkangelane("Frodo", "Shire");

            Console.WriteLine(superKangelane.Tervitus());
            Console.WriteLine($"Riietus: {superKangelane.Vormiriietus()}");
            Console.WriteLine($"Staatus: {superKangelane.MissiooniStaatus()}");
            Console.WriteLine(superKangelane.ToString());

            int ohustatud2 = 100;
            int paastetud2 = superKangelane.Paasta(ohustatud2);
            Console.WriteLine($"Päästitud inimesi: {paastetud2}/{ohustatud2}");

            Console.WriteLine("-------");

            Console.WriteLine("3. Fail: andmed.txt");
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\andmed.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Superman* / London");
                    writer.WriteLine("Batman / Tokyo");
                    writer.WriteLine("Spiderman / Los Angeles");
                    writer.WriteLine("Wonderwoman* / Paris");
                }

                Console.WriteLine($"Fail '{Path.GetFileName(filePath)}' on edukalt loodud asukohas:");
                Console.WriteLine(Path.GetFullPath(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tekkis viga faili loomisel: {ex.Message}");
            }

            Console.WriteLine("-------");

            Console.WriteLine("4. Klass: Program");
            LoeKangelasedFailist("andmed.txt");

            List<Kangelane> loetudKangelased = GetKangelased();

            foreach (var kangelanee in loetudKangelased)
            {
                Console.WriteLine("\n" + kangelanee.Tervitus());
                Console.WriteLine($"Riietus: {kangelanee.Vormiriietus()}");
                Console.WriteLine($"Staatus: {kangelanee.MissiooniStaatus()}");

                if (kangelanee is Superkangelane super)
                {
                    Console.WriteLine($"Osavus: {super.Osavus:F2} - Super kangelane!");
                }

                int ohustatud4 = 100;
                Console.WriteLine($"Päästitud inimesi: {kangelanee.Paasta(ohustatud4)}/{ohustatud4}");
            }

            Console.WriteLine("\nVajuta suvalist klahvi, et väljuda...");
            Console.ReadKey();
        }

        public static List<Kangelane> GetKangelased()
        {
            return kangelased;
        }

        public static void LoeKangelasedFailist(string failinimi)
        {
            try
            {
                string failiTee = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\andmed.txt");
                string[] read = File.ReadAllLines(failiTee);

                foreach (string rida in read)
                {
                    string[] osad = rida.Split('/');

                    if (osad.Length == 2)
                    {
                        string nimi = osad[0].Trim();
                        string linn = osad[1].Trim();

                        if (nimi.Contains("*"))
                        {
                            nimi = nimi.Replace("*", "").Trim();
                            kangelased.Add(new Superkangelane(nimi, linn));
                        }
                        else
                        {
                            kangelased.Add(new Kangelane(nimi, linn));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Viga faili lugemisel: {ex.Message}");
            }
        }
    }
}
