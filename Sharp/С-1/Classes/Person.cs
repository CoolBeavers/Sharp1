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
            get { return birthday; }
            set { birthday = value; }
        }

        public int BirthdayYear
        {
            get { return Birthday.Year; }
            set { Birthday.AddYears(value); }
        }

        public override string ToString() {
            return (Name + Surname + Birthday.ToString());
        }

        public virtual void ToShortString() 
        {
            Console.WriteLine(Name + Surname);
        }
    }
}
