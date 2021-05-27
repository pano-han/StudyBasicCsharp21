using System;

namespace Makeradius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요 : ");
            string sName = Console.ReadLine();
            Console.WriteLine("나이를 입력하세요 : ");
            string sAge = Console.ReadLine();
            Console.WriteLine("주소를 입력하세요 : ");
            string sAddress = Console.ReadLine();
            Console.WriteLine($"저는 {sAddress}에 살고 있는 {sAge}살 {sName}입니다.");
        }
    }
}
