using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa5
{
    internal class Film
    {
        // Свойства класса
        public string Pealkiri { get; set; } // Название фильма
        public int Aasta { get; set; } // Год выпуска
        public string Zanr { get; set; } // Жанр фильма


        // Конструктор класса
        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }

        public override string ToString()
        {
            return $"{Pealkiri} ({Aasta}), žanr: {Zanr}"; // Преобразует объект Film в строку для удобного вывода
        }

        public static List<Film> LooFilmideNimekiri() // Создает и возвращает предопределенный список фильмов
        {
            return new List<Film> // List<Film> - список объектов Film/Возвращаемое значение
            {
                new Film("Inception", 2010, "Sci-Fi"),
                new Film("The Shawshank Redemption", 1994, "Drama"),
                new Film("The Dark Knight", 2008, "Action"),
                new Film("Pulp Fiction", 1994, "Crime"),
                new Film("The Godfather", 1972, "Crime"),
                new Film("Interstellar", 2014, "Sci-Fi")
            };
        }

        public static List<Film> LeiaZanriFilmid(List<Film> filmid, string zanr)
        /*
         * filmid - список фильмов для поиска
         * zanr - искомый жанр (без учета регистра)
         */
        {
            return filmid.Where(f => f.Zanr.Equals(zanr, StringComparison.OrdinalIgnoreCase)).ToList();
            /*
             * метод Where для фильтрации и Equals с StringComparison.OrdinalIgnoreCase для регистронезависимого сравнения
             */
        }

        public static Film LeiaUusimFilm(List<Film> filmid)
        {
            return filmid.OrderByDescending(f => f.Aasta).FirstOrDefault();
            /*
             * Сортирует фильмы по году выпуска в обратном порядке (OrderByDescending)
             * Берет первый элемент (FirstOrDefault)
             * Возвращает null, если список пуст
             */
        }

        public static Dictionary<string, List<Film>> GrupeeriZanriteKaupa(List<Film> filmid)
        {
            return filmid.GroupBy(f => f.Zanr)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }

        public static void KuvaFilmid(List<Film> filmid)
        {
            foreach (var film in filmid)
                Console.WriteLine(film);
        }
    }
}
