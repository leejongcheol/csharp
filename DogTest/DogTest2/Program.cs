﻿using System;
namespace ConsoleApplication2{
    public class Dog : object  {
        public string name { get; set; }
        public void jitda()       {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Pudle : Dog   {
        public void work() { Console.WriteLine(name + "가 일한다."); }
    }
    public class Jindo : Dog   {
        public void run() { Console.WriteLine(name + "가 달린다."); }
    }
    class DogManager   {
        static void Main()      {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).work();
        }
    }
}
