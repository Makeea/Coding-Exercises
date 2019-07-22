using System;
public class MathCounter
{
    public static void Main()
    {
        int num;
		
    Console.Write("\n\n");
    Console.Write("prints out the numbers 1 to 100 (inclusive). \nIf the number is divisible by 3, print Crackle instead of the number. \nIf it's divisible by 5, print Pop. \nIf it's divisible by both 3 and 5, print CracklePop:\n");
    Console.Write("---------------------------------------");
    Console.Write("\n\n");
		for (num = 1; num <= 100; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine("CracklePop\n");
                

            else if (num % 3 == 0)
                Console.WriteLine("Crackle\n");

            else if (num % 5 == 0)
                Console.WriteLine("Pop\n");

            else
                Console.WriteLine("{0} \n", num);
        }
    }
}