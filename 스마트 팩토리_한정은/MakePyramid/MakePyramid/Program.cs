﻿using System;

namespace MakePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                if (i == 6)
                {
                    Console.Write('\n');
                }

                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }
    }
}
