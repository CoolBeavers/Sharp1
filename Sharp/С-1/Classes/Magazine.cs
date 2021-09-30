﻿using System;
using System.Collections.Generic;
using System.Text;
using static С_1.Program;

namespace С_1.Classes
{
    class Magazine
    {
        private string nameMag;
        private Frequency periodMag;
        private DateTime dateMag;
        private int countMag;

        private static Article _article = new Article();
        private Article[] listArticle = new Article[_article.countArticle];

        public Magazine(string _nameMag, Frequency _periodMag, DateTime _dateMag, int _countMag) 
        {
            nameMag = _nameMag;
            periodMag = _periodMag;
            dateMag = _dateMag;
            countMag = _countMag;
        }

        public Magazine() : this("Мурзилка", 0, new DateTime(2000, 1, 1), 15) 
        {
        }

        public string NameMag
        {
            get { return nameMag; }
            set { nameMag = value; }
        }
        public Frequency PeriodMag
        {
            get { return periodMag; }
            set { periodMag = value; }
        }
        public DateTime DateMag
        {
            get { return dateMag; }
            set { dateMag = value; }
        }
        public int CountMag
        {
            get { return countMag; }
            set { countMag = value; }
        }
        public double MiddleRat
        {
            get { return _article.sumRait/_article.countArticle; }
        }

        public bool this[Frequency _frequency] => _frequency == periodMag;

        public void AddArticles(params Article[] _args) 
        {
            for (int i = 0; i < _args.Length; i++) 
                Console.WriteLine(_args[i] + "\n");
        }

        public override string ToString()
        {
            foreach (Article _art in listArticle)
                Console.WriteLine(_art.ToString() + "\nРейтинг: " + _art.Raiting + "\n");
            return "------ \nНазвание журнала: " + nameMag + "\nПериод: " + periodMag + "\nДата выхода: " + dateMag.ToLongDateString() + "\nТираж: " + countMag + "\n------\n";

        }

        public virtual string ToShortString()
        {
            return "Название журнала: " + nameMag + "\nПериод: " + periodMag + "\nДата выхода: " + dateMag.ToLongDateString() + "\nСредний рейтинг: " + MiddleRat;
        }
    }
}
