using System;
namespace OutParameter
{
    class Program
    {
        // User Defined Functions
        public void Show(out int val) //Out parameter
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating Value
        }
        // Main function, execution entry point of the Program
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object Program
            Console.WriteLine("Value Before Passing out variable "+val);
            program.Show(out val); // Passing out argument
            Console.WriteLine("Value after recieving the out variable "+val);
        }
    }
}