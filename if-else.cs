using System;
public class ifexample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num%2==0)
        {
            Console.WriteLine("it is even number");
        }
        else
        {
            Console.WriteLine("it is odd number");
        }
    }
}