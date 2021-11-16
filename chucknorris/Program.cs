using System;
using System.IO;

namespace chucknorris
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"C:\Users\opilane\samples\Chuck.txt";
            //string[] jokesaboutchuck = File.ReadAllLines(filepath);

            //Random rnd = new Random();
            //int randomindex = rnd.Next(0, jokesaboutchuck.Length);
            //Console.WriteLine(jokesaboutchuck[randomindex]);
            Console.WriteLine(getrandomjoke());
        }
        public static string getrandomjoke()

        {
            string filepath = @"C:\Users\opilane\samples\Chuck.txt";
            string[] jokesaboutchuck = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomindex = rnd.Next(0, jokesaboutchuck.Length);
            return jokesaboutchuck[randomindex];


        }


    }
}
