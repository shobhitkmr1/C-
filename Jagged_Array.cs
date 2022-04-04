using System;
public class JaggedArrayTest
{
    public static void Main()
    {
        int[][] arr = new int[2][]; // Declare the array of arrays
        arr[0] = new int[] {11,21,56,223}; // Initialization
        arr[1] = new int[] {43,445,65,43,22,12,3};
        // Traverse array elements
        for(int i=0;i<arr.Length;i++)
        {
            for(int j = 0;j<arr[i].Length;j++)
            {
                Console.WriteLine(arr[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}