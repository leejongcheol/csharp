using System;
namespace ConsoleApp2{
    public class Emp    {
        public string name;
    }
    internal class Program : Emp {
        static void Main(string[] args) {
            Emp e = new Emp();
            e.name = "홍길동";
            Console.WriteLine(e.name);
        }
    }
}
