using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa5
{
    internal class MainClass5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Uus ülesanne 6 – Lemmikloomade register");
            // список домашних животных
            List<Lemmikloom> lemmikloomad = Lemmikloom.KusiLemmikloomadeAndmeid();

            // все кошки/коты
            Lemmikloom.KuvaKassid(lemmikloomad);

            // средний возраст
            Lemmikloom.ArvutaKeskmineVanus(lemmikloomad);

            // самое старое животное
            Lemmikloom.LeiaVanimLoom(lemmikloomad);

            // поиск по имени
            Lemmikloom.OtsiLoomNimeJargi(lemmikloomad);

            Console.WriteLine("-------");

            Console.WriteLine("Uus ülesanne 4 – Filmide kogu");
            // список фильмов
            var filmid = Film.LooFilmideNimekiri();
            Console.WriteLine("Kõik filmid:");
            Film.KuvaFilmid(filmid);

            // список фильмов по жанру
            Console.WriteLine("\nSci-Fi žanri filmid:");
            var scifiFilmid = Film.LeiaZanriFilmid(filmid, "Sci-Fi");
            Film.KuvaFilmid(scifiFilmid);

            // самый новый фильм по году
            var uusimFilm = Film.LeiaUusimFilm(filmid);
            Console.WriteLine($"\nUusim film: {uusimFilm}");

            // все фильмы сгруппированы по фанрам
            var zanriteKaupa = Film.GrupeeriZanriteKaupa(filmid);
            Console.WriteLine("\nFilmide grupeerimine žanrite kaupa:");
            foreach (var zanr in zanriteKaupa)
            {
                Console.WriteLine($"\nŽanr: {zanr.Key}");
                Film.KuvaFilmid(zanr.Value);
            }

            Console.WriteLine("-------");

            Console.WriteLine("Uus ülesanne 7 – Valuutakalkulaator");

            List<Valuuta> valuutadeList = Valuuta.LooValuutadeList();
            Valuuta.ArvutaVahetused(valuutadeList);

            Console.WriteLine("-------");

            // ArrayList (System.Collections)
            Console.WriteLine("5 osa klassis");
            Console.WriteLine("ArrayList (System.Collections)");
            FunktsioonidOsa5.Esimene_naide();

            // Tuple (järjendid)
            Console.WriteLine("Tuple (järjendid)");
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");

            // List (System.Collections.Generic)
            Console.WriteLine("List (System.Collections.Generic)");
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });   // class person.cs
            people.Add(new Person() { Name = "Mirje" });
            people.Add(new Person() { Name = "Juku" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);


            Console.WriteLine("LinkedList (System.Collections.Generic)");
            // LinkedList (System.Collections.Generic)
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);


            Console.WriteLine("Dictionary<TKey, TValue> – Sõnastik");
            // Dictionary<TKey, TValue> – Sõnastik
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);


            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }
    }
}
