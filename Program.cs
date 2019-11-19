using System;

namespace CodeReviewTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine("0,1")
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("a+b");
                a = b;
                b = a;
            }
        }
    }
}
