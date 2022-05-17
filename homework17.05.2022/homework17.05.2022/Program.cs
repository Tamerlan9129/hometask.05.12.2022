using System;

namespace homework17._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nurlan Emil Tural Yusif";
            
            Console.WriteLine(ReverseName(name));
        }

        static string ReverseName(string name)
        {
            string revName = "";
            string[] nameArr = name.Split(' ');

            foreach(var item in nameArr)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {

                    revName += item[i];
                }
                revName += " ";
            }
            return revName;

        }
    }
}