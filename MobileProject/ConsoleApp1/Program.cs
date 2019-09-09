using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Text = "12+3";
            string[] elements = Text.Split('+', '-', 'x', '/', '%');
            // List<string> operations = new List<string>(); regex
            if (elements[0] == "+" || elements[0] == "-" || elements[0] == "x " || elements[0] == "/" || elements[0] == "%")
            {
                Text = "Error";
            }

            var result = Int32.Parse(elements[0]);
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == "+")
                {
                    result += Int32.Parse(elements[i]);
                }

                if (elements[i] == "-")
                {
                    result -= Int32.Parse(elements[i]);
                }
                if (elements[i] == "/")
                {
                    result /= Int32.Parse(elements[i]);
                }
                if (elements[i] == "x")
                {
                    result *= Int32.Parse(elements[i]);
                }
                if (elements[i] == "%")
                {
                    result %= Int32.Parse(elements[i]);
                }
            }


            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
