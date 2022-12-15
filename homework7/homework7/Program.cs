using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindBiggest(-1, 3, -4));
            Console.WriteLine(Power(5, 2));
            Console.WriteLine(Avg(2, 4, 6, 8));
            Console.WriteLine(SumofDigits(256));
            Console.WriteLine(hasA("salam"));
            Console.WriteLine(Square(5));
            Console.WriteLine(Sum(7, 9));
        }//Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int x, int y)
        {
            return x + y;
        }

        //Verilmiş ədədin kvadratını qaytaran metod

        static int Square(int x)
        {
            return x * x;
        }
        // Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
        static bool hasA(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                    return true;
            }
            return false;
        }//Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int SumofDigits(int n)
        {
            int m;
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = (n - (n % 10)) / 10;

            }
            return sum;
        }
        //Verilmiş 4 ədədin ortalamasını tapıb qaytaran metod
        static int Avg(int x, int y, int z, int w)
        {
            int sum = x + y + z + w;
            int count = 4;
            return sum / count;

        }//Verilmiş ədədin verilmiş qüvvətini tapan metod
        static int Power(int x, int pow)
        {
            var result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= x;

            }
            return result;

        }//Verilmiş 3 ədəddən ən böyüyünü tapan metod
        static int FindBiggest(int x, int y, int z)
        {
            if (x > y && x > z)

            {
                return x;
            }
            if (y > x && y > z)

            {
                return y;
            }
            else
                return z;
        } //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
        static int SumofDigitsofArray(int[] arr)
        {
            int sum = 0;
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            }
            return sum;
        }
        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
        static int FindBiggestofArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }//Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod
        static int FindBiggestIndex(int[] arr)
        { int max = 0;
            for (int i = 0; i < arr.Length; i++)
                if (i > max)
                {
                    max =i;
                }
            return max;
        }
        //Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın
static int FindStringIndex(string[] str, string str)








    }


}

