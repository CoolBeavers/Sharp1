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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Person objPers = obj as Person;
            if (obj as Person == null)
            {
                return false;
            }
            return objPers.Name == name && objPers.Surname == Surname && objPers.Birthday == birthday;
        }
        public override int GetHashCode()
        {
            int hashcode = 0;
            char[] NameChar = Name.ToCharArray();

            foreach (char ch in NameChar)
            {
                hashcode += Convert.ToInt32(ch);
            }
            char[] SurnameChar = Surname.ToCharArray();
            foreach (char ch in SurnameChar)
            {
                hashcode += Convert.ToInt32(ch);
            }
            hashcode += Birthday.Year * Birthday.Month;
            return hashcode;
        }
        public static bool operator ==(Person lpers, Person rpers)
        {
            if (ReferenceEquals(lpers, rpers))
            {
                return true;
            }
            if ((object)lpers == null || (object)rpers == null)
            {
                return false;
            }
            return lpers.Name == rpers.Name && lpers.birthday == rpers.Birthday && lpers.Surname == rpers.Surname;
        }
        public static bool operator !=(Person lpers, Person rpers)
        {
            return !(lpers == rpers);
        }
    }
}
