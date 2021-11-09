using System;
using System.Diagnostics;
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
            var timer = new Stopwatch();

            Magazine _magazine = new Magazine("Математический Анализ", Frequency.Weekly, new DateTime(1995, 3, 11), 10);
            _magazine.AddArticles(
                new Article("Программирование", new Person("Никита", "Ефимов", new DateTime(2002, 3, 1)), 4.2),
                new Article("Электротехника", new Person("Вадим", "Бобров", new DateTime(2002, 1, 23)), 4.4)
            );
            Console.WriteLine(_magazine.ToShortString());

            Console.WriteLine("\n" + _magazine[Frequency.Monthly] + " " + _magazine[Frequency.Weekly] + " " + _magazine[Frequency.Yearly] + " \n");

            Console.WriteLine("\n");
            _magazine.NameMag = "Как стать успешным?";
            _magazine.PeriodMag = Frequency.Monthly;
            _magazine.DateMag = new DateTime(2021, 9, 28);
            _magazine.CountMag = 12;
            Console.WriteLine(_magazine.ToString() + " \n\n");

            Console.WriteLine(_magazine.ToString());

            Edition _edition = new Edition("Окружающий мир", new DateTime(2021, 9, 11), 4);
            Edition _edition1 = new Edition("Окружающий мир", new DateTime(2021, 9, 11), 4);
            Console.WriteLine(_edition.ToString());
            Console.WriteLine(_edition1.ToString());

            Console.WriteLine(_edition.Equals(_edition1));
            Console.WriteLine(_edition == _edition1);
            Console.WriteLine(string.Format(" _edition: {0}, _edition1: {1} ", _edition.GetHashCode(), _edition1.GetHashCode()));

            try
            {
                _edition.tirageEdition = -2;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Magazine _magazine1 = (Magazine)_magazine.DeepCopy();
            _magazine.NameMag = "NFS";
            _magazine.CountMag = 11;
            Console.WriteLine(_magazine.ToString());
            Console.WriteLine(_magazine1.ToString());

            foreach (var a in _magazine.GetArtic(2))
                Console.WriteLine(a);
            foreach (var b in _magazine.GetNameArtic("Программирование"))
                Console.WriteLine(b);

            Console.Write("Введите число столбцов и строк через разделители '/', ' ', '_', '*': ");
            string[] temp = Console.ReadLine().Split('/', ' ', '_', '*');
            int ncolumn = Int32.Parse(temp[0]);
            int nrow = Int32.Parse(temp[1]);

            Article[] firstArray = new Article[ncolumn * nrow];
            for (int i = 0; i < ncolumn * nrow; i++)
            {
                firstArray[i] = new Article();
            }

            Article[,] secondArray = new Article[nrow, ncolumn];
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    secondArray[i, j] = new Article();
                }
            }

            Article[][] thirdArray = new Article[nrow][];
            int a1;
            if (ncolumn > nrow)
                a1 = ncolumn - (nrow - 1);
            else
                a1 = nrow - (ncolumn - 1);

            for (int i = 0; i < nrow; i++)
            {
                thirdArray[i] = new Article[a1 + i];
                for (int j = 0; j < thirdArray[i].Length; j++)
                {
                    thirdArray[i][j] = new Article();
                }
            }

            timer.Start();
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i].NameArticle = "Программирование";
            }
            timer.Stop();
            Console.WriteLine($"Время, затраченное на инициализацию одномерного массива: {timer.ElapsedMilliseconds} мс");
            Console.WriteLine();

            timer.Restart();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    secondArray[i, j].NameArticle = "Программирование";
                }
            }
            timer.Stop();
            Console.WriteLine($"Время, затраченное на инициализацию двумерного массива: {timer.ElapsedMilliseconds} мс");
            Console.WriteLine();

            timer.Restart();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < thirdArray[i].Length; j++)
                {
                    thirdArray[i][j].NameArticle = "Программирование";
                }
            }
            timer.Stop();
            Console.WriteLine($"Время, затраченное на инициализацию зубчатого массива: {timer.ElapsedMilliseconds} мс");
            Console.WriteLine();
        }
    }
}
