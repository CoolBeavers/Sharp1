using System;
using System.Collections.Generic;
using System.Text;

namespace С_1.Classes
{
    class Article
    {
        public string NameArticle { get; set; }
        public Person Author { get; set; }
        public double Raiting { get; set; }

        private static Random rnd = new Random();
        public double sumRait = rnd.Next(0, 5);
        public int countArticle = 1;

        public Article(string nameArticle, Person authorArticle, double ratingArticle)
        {
            NameArticle = nameArticle;
            Author = authorArticle;
            Raiting = ratingArticle;

            countArticle++;
            sumRait += ratingArticle;
        }

        public Article()
        {
            NameArticle = "Программирование";
            Author = new Person("Иван", "Иванов", new DateTime(2000, 1, 1));
            Raiting = 5.0;
        }

        public override string ToString()
        {
            return ("Название статьи: " + NameArticle + "\nАвтор: " + Author.Name + " " + Author.Surname + "\nДата рождения: " + Author.Birthday.ToLongDateString());
        }
    }
}