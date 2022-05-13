using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] grade = { 10, 20, 20 };
			int Avar = CalcAvg(grade);
			if (Avar >= 60)
			{
				Console.WriteLine("Mezun oldunuz");
			}
			else
			{
				Console.WriteLine("Mezun ola bilmediniz");
			}
		}

		static int CalcAvg(int[] arr)
		{
			int count = 0;
			int sum = 0;
			foreach (int el in arr)
			{
				sum += el;
				count++;
			}
			int res = sum / count;
			return res;
		}
    }
}
