using System;
using System.Collections.Generic;
using System.Text;

namespace С_1.Classes
{
    class Exam
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public DateTime Day { get; set; }

        public Exam(string nameLesson, int ratingLesson, DateTime dateLesson) 
        {
            Name = nameLesson;
            Rating = ratingLesson;
            Day = dateLesson;
        }

        public Exam() 
        {
            Name = "";
            Rating = 0;
            Day = DateTime.Now;
        }

        public override string ToString() {
            return (Name + Rating + Day.Date);
        }
    }
}
