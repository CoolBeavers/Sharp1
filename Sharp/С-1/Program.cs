using System;
using С_1.Classes;

namespace С_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            person.Name = "Петр";
        }
    }
}
