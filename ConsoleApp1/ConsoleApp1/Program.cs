using System;
namespace ConsoleApp1 {
    class Emp {
        public string Name
        {
            get;
            set; 
        } 
    }
    class EmpTest {
        static void Main(string[] args) {
            Emp e = new Emp();
            e.Name = "홍길동";
            Console.WriteLine(e.Name);
        }        
    }
}
