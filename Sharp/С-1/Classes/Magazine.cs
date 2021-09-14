using System;
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
        private Article[] listArticle;

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
        public Article[] ArticleMag
        {
            get { return listArticle; }
            set { listArticle = value; }
        }
    }
}
