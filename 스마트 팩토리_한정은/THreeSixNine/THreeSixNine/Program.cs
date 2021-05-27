using System;

namespace THreeSixNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3, 6, 9! 3, 6, 9! 3, 6, 9! 3, 6, 9!");
            for (int i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write("짝!  ");
                }
                else 
                {
                    Console.Write(i+"  ");
                }
                  
                   
            }
        }
    }
}
