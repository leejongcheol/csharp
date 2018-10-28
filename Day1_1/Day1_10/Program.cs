using System;
class SumTest{
    static void Main()  {
        Console.WriteLine( Sum(1,2) );
        Console.WriteLine(Sum(1, 2, 3));
    }
    static int Sum(params int[] iArray )
    {
        int sum = 0;
        foreach( int number in iArray)
        {
            sum += number;
        }
        return sum;            
    }
}