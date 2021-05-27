using System;

namespace MakeMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7단 계산 시작");
            for (int i =1; i <10; i++)
            {
                Console.Write($" 7 * {i} = {7 * i}");
            }
            Console.WriteLine('\n'+ "8단 계산 시작");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" 8 * {i} = {8 * i}");
            }
            Console.WriteLine('\n' + "9단 계산 시작");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" 9 * {i} = {9 * i}");
            }
        }
    }
}
