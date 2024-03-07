using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "X";

            //Ask user to write something
            Console.Write("String: ");
            string str = Console.ReadLine();

            //Ask user to write a character
            Console.Write("\nLetter: ");
            string letter = Console.ReadLine();
            
            //Replacing the characters
            str = str.Replace(letter, x);
            
            //Print string 
            Console.WriteLine($"New String: {str}");
            
        }
    }
}
