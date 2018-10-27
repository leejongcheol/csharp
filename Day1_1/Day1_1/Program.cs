using System;
class TypeCastExample1
{
    public static void Main()
    {
        int c = 50000;
        try
        {
            short d = checked((short)c); //명시적으로 형변환 하지않으면 오류!
            Console.WriteLine("Short : {0}", d);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}