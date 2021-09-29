using System;
using С_1.Classes;

namespace С_1
{
    class Program
    {

        public enum Frequency
        {
            Weekly,
            Monthly,
            Yearly
        }
        static void Main(string[] args)
        {
            Magazine _magazine = new Magazine("Мурзилка", Frequency.Weekly, new DateTime(1995, 3, 11), 10);
            Console.WriteLine(_magazine.ToShortString());

            Console.WriteLine("\n" + _magazine[Frequency.Monthly] + " " + _magazine[Frequency.Weekly] + " " + _magazine[Frequency.Yearly] + " \n");

            Console.WriteLine("\n");
            _magazine.NameMag = "Лепесток";
            _magazine.PeriodMag = Frequency.Monthly;
            _magazine.DateMag = new DateTime(2021, 9, 28);
            _magazine.CountMag = 12;
            Console.WriteLine(_magazine.ToString() + " \n\n");

            _magazine.AddArticles(
                new Article("Валенок", new Person("Никита", "Ефимов", new DateTime(2002, 3, 1)), 4.2),
                new Article("Олежок", new Person("Вадим", "Бобров", new DateTime(2002, 1, 23)), 4.4)
            );
            Console.WriteLine(_magazine.ToString());
        }
    }
}
