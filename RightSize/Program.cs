using System;
using System.Runtime.Intrinsics.Arm;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length > 6)
                {
                    break;
                }

                if (s.Length > 3)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}