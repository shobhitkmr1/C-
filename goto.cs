using System;
public class GotoExample
{
    public static void Main(string[] args)
    {
        ineligible:
        Console.WriteLine("You are not eligible to vote ! ");
        Console.WriteLine("Enter Your Age:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age<18)
        {
            goto ineligible;
        }
        else
        {
            Console.WriteLine("You are Eligible to vote ! ");
        }
        Console.ReadLine();
    }
}