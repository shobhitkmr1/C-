using System;
public class arrayExample
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5]; // creating array
        arr[0] = 10; // initializing array
        arr[2] = 20; // initializing array
        arr[4] = 30; // initializing array
        // Traversing array of
        for(int i = 0;i < arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}