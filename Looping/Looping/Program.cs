using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i <=10; i++)
            {
               Console.WriteLine(i+"*"+n+"="+(i*n));
            }
        }
    }
}
