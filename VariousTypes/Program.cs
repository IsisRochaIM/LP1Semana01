using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            int vallue1 = 6;
            short vallue2 = 8;
            long vallue3 = 10;
            Console.WriteLine(vallue1);
            Console.WriteLine(vallue2);
            Console.WriteLine(vallue3);

            char char1n = '\uF31E';
            char char2 = '\uF438';
            char char3 = '\uF36E';
            Console.WriteLine(char1n);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
            
            float real1 = 3.1415f;
            decimal real2 = 3.1415m;
            Console.WriteLine(real1);
            Console.WriteLine(real2);

            bool boolean1 = 5 < 3; 
            bool boolean2 = 5 > 3;
            Console.WriteLine(boolean1);
            Console.WriteLine(boolean2);
        }
    }
}
