using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using С_1.Interface;
using static С_1.Program;

namespace С_1.Classes
{
    class Magazine : Edition
    {
        private IRateAndCopy _iRateAndCopy;

        private string nameMag;
        private Frequency periodMag;
        private DateTime dateMag;
        private int countMag;

        private ArrayList listEditor = new ArrayList();
        private ArrayList listArticle = new ArrayList();


        private Edition _edition { get; set; }
        private static Article _article = new Article();

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
            get { return(_article.countArticle == 0) ? 4.5 : _article.sumRait/_article.countArticle; }            
        }

        public bool this[Frequency _frequency] => _frequency == periodMag;

        public void AddArticles(params Article[] _args) 
        {
            for (int i = 0; i < _args.Length; i++) 
                Console.WriteLine(_args[i] + "\n");
        }

        public void AddEditors(params Person[] _args)
        {
            for (int i = 0; i < _args.Length; i++)
                Console.WriteLine(_args[i] + "\n");
        }

        public IEnumerable GetArtic(double it)
        {
            foreach (Article _art in listArticle) 
                if (_art.Raiting > it)
                    yield return _art.ToString();
        }

        public IEnumerable GetNameArtic(string it)
        {
            foreach (Article _art in listArticle)
                if (_art.NameArticle.IndexOf(it) > 0)
                    yield return _art.ToString();
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

        public virtual object DeepCopy()
        {
            return new Magazine(this.nameMag, this.periodMag, this.dateMag, this.countMag); ;
        }
    }
}
