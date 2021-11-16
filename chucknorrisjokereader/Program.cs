using System;
using System.IO;

namespace chucknorrisjokereader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of jokes");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            getjokes(usernumber);
        }
        private static void getjokes(int jokesnumber)
        {
            string filepath = @"C:\Users\opilane\samples\Chuck.txt";
            string[] jokesaboutchuck = File.ReadAllLines(filepath);

            if(jokesnumber > jokesaboutchuck.Length)
            {
                jokesnumber = jokesaboutchuck.Length;
            }

            for(int i = 0; i < jokesnumber; i++)
            {
                Console.WriteLine(jokesaboutchuck[i]);
            }
        }
    }
}
