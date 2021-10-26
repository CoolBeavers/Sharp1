using System;
using System.Collections.Generic;
using System.Text;

namespace С_1.Classes
{
    class Edition
    {
        protected string nameEdition { get; set; }
        protected DateTime dateEdition { get; set; }
        protected int tirageEdition;

        public Edition(string _nameEdition, DateTime _dateEdition, int _tirageEdition) 
        {
            nameEdition = _nameEdition;
            dateEdition = _dateEdition;
            tirageEdition = _tirageEdition;
        }

        public Edition() 
        {
            nameEdition = "Издание";
            dateEdition = new DateTime(2000, 1, 1);
            tirageEdition = 3;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }

            Edition objEdition = obj as Edition;
            if (obj as Edition == null) {
                return false;
            }
            return objEdition.nameEdition == nameEdition && objEdition.dateEdition == dateEdition && objEdition.tirageEdition == tirageEdition;
        }

        public override int GetHashCode()
        {
            int hashcode = 0;
            char[] NameChar = nameEdition.ToCharArray();

            foreach (char ch in NameChar) {
                hashcode += Convert.ToInt32(ch);
            }

            hashcode += tirageEdition;
            hashcode += dateEdition.Year * dateEdition.Month;
            return hashcode;
        }

        public static bool operator ==(Edition led, Edition red)
        {
            if (ReferenceEquals(led, red)) {
                return true;
            }
            if ((object)led == null || (object)red == null) {
                return false;
            }
            return led.nameEdition == red.nameEdition && led.dateEdition == red.dateEdition && led.tirageEdition == red.tirageEdition;
        }

        public static bool operator !=(Edition led, Edition red)
        {
            return !(led == red);
        }

        public override string ToString()
        {
            return "Название издания: " + nameEdition + "\nДата: " + dateEdition + "\nТираж: " + tirageEdition;
        }

        public virtual object DeepCopy()
        {
            return 1;
        }

        public int TirageEdition
        {
            get { return tirageEdition; }
            set { tirageEdition = value; }
        }
    }
}
