using System;
public class MathCounter
{
    public static void Main()
    {
        int num;

        for (num = 1; num <= 100; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine("CracklePop");

            else if (num % 3 == 0)
                Console.WriteLine("Crackle");

            else if (num % 5 == 0)
                Console.WriteLine("Pop");

            else
            Console.WriteLine("{0} ", num);
        }
    }
}