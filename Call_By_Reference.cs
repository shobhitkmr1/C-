using System;
namespace CallByReference
{
    class Program
    {
        // User Defined Function
        public void Show(ref int val)
        {
            val *= val; // Manipulating value
            Console.WriteLine("Inside the show function "+val);
            // No return statement 
        }
        // Main function,Execution entry point of the Program
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object Program
            Console.WriteLine("Before Calling the function "+val);
            program.Show(ref val);
            Console.WriteLine("After Calling the function "+val);
        }
    }
}