using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1pram
{
    internal class Class1prams
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }
        public static void Main()
        {
            string s = "hello";

                DateTime dob;
                Console.WriteLine("enter your dob?");
            dob = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine($"Dob year = {dob.year},Dob Month={dob.Month}");
            
            try
            {
                Console.WriteLine("enter a number");
                //x = int.Parse(Console.ReadLine());

               // Console.WriteLine(Sum(1, 2, 3, x));
            }
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("please enter a number <=10000");//user friendly messages
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("please enter a valid number");//user friendly messages
            //}
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, error occured...contact admin");
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine(Sum(a));
        }
    }
}



public class returnAge
{
    public static int age(DateTime dob)
    {
        int CurrentYear = DateTime.Now.Year;
        int C = DateTime.Now.Month;
        return CurrentYear - dob.Year;

    }

    public static void Main()
    {


        DateTime date = DateTime.Parse(Console.ReadLine());
        int res = (age(date)); ;
        Console.WriteLine($"your age is{res}");
    }
}


