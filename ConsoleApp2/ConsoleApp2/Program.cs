using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Yashinizi daxil edin ");
			string ageStr = Console.ReadLine();
			bool isParsable = int.TryParse(ageStr, out int age);
			int[] ages = { 17, 19, 22, 25, 27, 32 };
			bool flag = false;
			foreach (int el in ages)
			{
				if (!isParsable)
				{
					Console.WriteLine("Yashinizi duzgun daxil edin");
					break;
				}
				else 
				{
					if(age == el)
                    {
						flag = true;
						
						break;
						
                      
					}
					




				}

				
			}Console.WriteLine(flag);
			

		}


	}
}