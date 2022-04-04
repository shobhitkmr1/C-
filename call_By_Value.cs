using System;
namespace CallByValue
{
    class Program
    {
        public void Show(int val)
        {
            val *= val; // Manipulating value
            Console.WriteLine("Inside the show function "+val);
            // No Return statement
        }
        // Main function, execution entry point of the Program
        static void Main(string[] args)
        {
            int val =50;
            Program program = new Program(); // Creating Object Program
            Console.WriteLine("Before calling the function "+val);
            program.Show(val); // Calling Function By Passing Value
            Console.WriteLine("After calling the function "+val);
        }
        
    }
}