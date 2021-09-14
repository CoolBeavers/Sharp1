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

        public Article(string nameArticle, Person authorArticle, double ratingArticle) 
        {
            NameArticle = nameArticle;
            Author = authorArticle;
            Raiting = ratingArticle;
        }

        public Article() 
        {
            NameArticle = "Программирование";
            Author = new Person("Иван", "Иванов", new DateTime(2000, 1, 1));
            Raiting = 5.0;
        }

        public override string ToString() {
            return (NameArticle + Author.ToString() + Raiting.ToString());
        }
    }
}
