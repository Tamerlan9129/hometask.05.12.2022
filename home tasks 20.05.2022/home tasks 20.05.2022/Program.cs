using System;

namespace home_tasks_20._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            //int[] arr = { 13, 5, 8, 4, 26, 15, 3 };
            //int [] reversArr = CustomSort(arr);
            //foreach (int item in reversArr) 
            //{
            //    Console.WriteLine(item);
            //}

            #region task1
            //static int[] CustomSort(int[] arr)
            //{
            //    int rev = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length-1; j++)
            //        {
            //            if (arr[j] > arr[i])
            //            {
            //                rev = arr[i];
            //                arr[i] = arr[j];
            //                arr[j] = rev;

            //            }

            //        }

            //    }
            //    Array.Reverse(arr);
            //    return arr;

            //}
            #endregion

            //task2
            //string[] name = { "Tamerlan", "Yusif", "Nurlan","Faiq"};
            //ContainsChar(name,'F');
            //task 3
            //Student number1 = new Student
            //{
            //    Name = "Tamerlan",
            //    HomeworkGrades = new int[] { 60, 60, 50, 90, 100 },
            //    ProjectGrades = new int[] { 50, 60, 70, 30, 90 },
            //    FinalGrade = 50,
            //    Davamiyyet = new bool[] { true, false, true, true, true }
            //};
            //number1.GradeTotal();
            User myuser = new User
            {
               Name = "tamerlan",
               Password = "fuhd123",
               Mail = "tamerlankha@code.edu.az",
               Balance = 253.56,
               Address = "Baku,S.S.Axundov 31/23"
            };
            Console.WriteLine(myuser.IsPasswordValid());
        }
        #region task2
        //static void ContainsChar(string[] name,char a) 
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (name[i].Contains(a))
        //        {

        //            Console.WriteLine(name[i]);
        //        }
        //    }
        //}
        #endregion
    }

    #region task3
    //class Student
    //{
    //    public string Name;
    //    public int[] HomeworkGrades;
    //    public int[] ProjectGrades;
    //    public int FinalGrade;
    //    public bool[] Davamiyyet;


    //    public int GradeHo()
    //    {
    //        int sum = 0;
    //        foreach (int el in HomeworkGrades)
    //        {

    //            sum += el;
    //        }
    //        return sum;
    //    }

    //    public int GradePro()
    //    {
    //        int sum = 0;
    //        foreach (int el in ProjectGrades)
    //        {
    //            sum += el;

    //        }
    //        return sum;

    //    }
    //    public int GradeHome()
    //    {

    //        int sum = 0;
    //        foreach (int el in HomeworkGrades)
    //        {
    //            sum += el;
    //        }
    //        return sum;
    //    }

    //    public int GradeDavam()
    //    {
    //        int sum = 0;
    //        foreach (var el in Davamiyyet)
    //        {
    //            if (el == true)
    //            {
    //                sum++;
    //            }
    //        }
    //        return sum;
    //    }
    //    public void GradeTotal()
    //    {
    //        int totalScore = (GradeHome() / 100 * 25) + (GradePro() / 100 * 25) + (GradeDavam() / 100 * 10) + FinalGrade / 100 * 40;
    //        if (totalScore > 90)
    //        {
    //            Console.WriteLine("HighHonour");
    //        }
    //        else if (totalScore > 80)
    //        {
    //            Console.WriteLine("Honour");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Normal");
    //        }
    //    }
    //}
    #endregion

    class User 
    {
        public string Name;
        public string Password;
        public string Mail;
        public double Balance;
        public string Address;

        public  bool IsPasswordValid() 
        {
            bool flag = true;
            string num = "0123456789";
            
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password.Length < 6)
                {
                    flag = false;
                    break;
                }
                for (int j = 0; j < Name.Length; j++)
                {
                  if (Password[i] == Name[j])
                {
                        
                    flag = false;
                        break;
                }
                }
                for (int b = 0; b < num.Length; b++)
                {
                    if (Password[i] != num[b]) 
                    {
                        flag = false;
                        
                    }
                }
                
                
            }return flag;
        }
    }
}
