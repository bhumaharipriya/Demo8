using System;

namespace Demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
        int num2 = 20;

        swap(ref num1, ref num2);
        Console.WriteLine("num1: {0}, and num2: {1}", num1, num2);
    }

    static void swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        }
    }
}
