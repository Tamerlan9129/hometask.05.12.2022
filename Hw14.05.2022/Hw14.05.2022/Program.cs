using System;

namespace Hw14._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] arr = {5, 6, 6, };
            //Console.WriteLine(arraySumEvenOdd(arr));
            PrintPyramid(5);
        }
        static void PrintPyramid(int en){
            
            
            
                for (int i = 0; i < en; i++)
                {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

                

            
                
            
            
        }
        #region task 1
        //static bool arraySumEvenOdd(int[] arr)
        //{
        //    int sum = 0;
        //    bool flag = false;
        //    foreach (int el in arr)
        //    {
        //        sum += el;
        //    }
        //    if (sum % 2 == 0)
        //    {
        //        flag = true;
        //        return flag;
        //    }
        //    else
        //    {
                
        //        return flag;
        //    }
            
        //}
        #endregion
    }

}
