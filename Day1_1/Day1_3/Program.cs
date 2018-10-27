using System;
namespace Day1_3{
    class Program    {
        static void Main(string[] args)
        {
            string s = args[0];
            int number = int.Parse(s);
            for(int i=0; i <= number; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
