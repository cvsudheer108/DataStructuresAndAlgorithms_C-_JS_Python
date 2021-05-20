using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(20);
        }

        static void FizzBuzz(int inum)
        {
            for(int num=0;num<inum;num++)
            {
                if(num % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (num % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(num);
            }
        }
    }
}
