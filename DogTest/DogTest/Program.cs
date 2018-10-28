using System;
namespace ConsoleApplication2{
    public class Pudle    {
        public string name;
        public void jitda()  {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Jindo    {
        public string name;
        public void jitda()    {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    class DogManager  {
        static void Main()     {
            Pudle p = new Pudle(); p.name = "푸들이"; p.jitda();
            Jindo j = new Jindo(); j.name = "진도이"; j.jitda();
        }
    }
}