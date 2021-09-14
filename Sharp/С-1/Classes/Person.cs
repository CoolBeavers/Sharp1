using System;
using System.Collections.Generic;
using System.Text;

namespace С_1.Classes
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthday;

        public Person(string nameValue, string surnameValue, DateTime birthdayValue)
        {
            name = nameValue;
            surname = surnameValue;
            birthday = birthdayValue;
        }
        public Person() : this("Иван", "Иванов", new DateTime(2000, 1, 1))
        {
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime Birthday
        {

        }

        public int Year
        {
            get { return Birthday.Year; }
            set { Birthday = new DateTime(value, Birthday.Month, Birthday.Day); }

        }

        public override string ToString()
        {
            string str = Name + " " + Surname + " " + Birthday.ToShortDateString();
            return str;
        }

        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }
    }

}
