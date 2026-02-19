using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            
            string basicString = "Pão de Laranja";
            string specialString = "banana\\\nmaçã\\\n\"abacate\"";
            string unicodeString = "\u03A9";

            Console.WriteLine(basicString);
            Console.WriteLine(specialString);
            Console.WriteLine(unicodeString);

            
        }
    }
}
