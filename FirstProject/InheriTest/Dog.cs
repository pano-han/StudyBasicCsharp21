using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriTest
{
    class Dog : Animal //Animal 클래스를 Dog가 상속받겠다는 의미. -> Animal 클래스에 있는 속성은 Dog에 없어도 됨.
    {
        public string Color { get; set; }
        public Dog() { this.Age = 0; this.Color = "흰색"; }
        public void Bark()
        {
            Console.WriteLine("왕왕");
        }
    }
}
