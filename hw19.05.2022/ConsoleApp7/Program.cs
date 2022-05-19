using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 2,8,12,33};
            int[] arr2 = { 12,33 };
            Console.WriteLine(IsArrayContains(arr1,arr2));

        }
        static bool IsArrayContains(int [] arr, int[] arr2) {

            string convarr = string.Join(",", arr);
            string convarr2 = string.Join(",",arr2);
            if (convarr.Contains(convarr2)) {

                    return true;
                
               
            }
            return false;
        }
    }
}
