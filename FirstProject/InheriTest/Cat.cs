﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriTest
{
    class Cat : Animal
    {
        public Cat() { this.Age = 0; }
        public void Meow()
        {
            Console.WriteLine("야옹야옹");
        }
    }
}
