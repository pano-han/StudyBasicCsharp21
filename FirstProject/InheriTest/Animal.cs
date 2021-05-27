using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriTest
{
    // Access Modifier :
    // public - 공유.
    // protected - 보호되는 것. 상속만 가능. 
    // private - 보안적으로 막은 것.
    class Animal
    {
        public int Age { get; set; }
        public Animal () { this.Age = 0;} //생성자

        public void Eat()
        {
            Console.WriteLine("먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("잡니다.");
        }
        public void Bark()
        {
            Console.WriteLine("왕왕");
        }
    }
}
