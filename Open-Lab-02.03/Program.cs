using System;

namespace Open_Lab_02._03
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return (a % b);
        }
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(n1, n2));
        }
    }
}
