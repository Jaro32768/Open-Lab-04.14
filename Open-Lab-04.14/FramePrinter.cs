using System;
using System.IO;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int longest = 0;
            for (int l = 0; l < strings.Length; l++)
            {
                if (strings[l].Length > longest)
                {
                    longest = strings[l].Length;
                }
            }
            for (int i = 1; i < longest + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("* ");
                Console.Write(strings[i]);
                for (int s = 0; s < longest - strings[i].Length; s++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            for (int i = 1; i < longest + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}