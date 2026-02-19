using System;
using System.Security.Cryptography;

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

            string s1 = "palavra " + 4;
            string s2 = "Eu gosto de " + basicString;
            int vallue4 = 5 + 8;
            int vallue5 = 8 - 3; 
            string s3 = $"A soma de x e y é {vallue4 + vallue5}";
            string s4 = $"O valor de x é {vallue4} que é a soma de 5 e 8";
            string s5 = $"O valor de y é {vallue5} que é a subtração de 8 por 3";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
                        
        }
    }
}
