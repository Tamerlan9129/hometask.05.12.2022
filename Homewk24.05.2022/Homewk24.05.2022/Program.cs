using System;

namespace Homewk24._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man1 = new Person("Tamerlan", "Alimardanli", 30);
            Console.WriteLine(man1.IsAdult);
        }
    }
}
