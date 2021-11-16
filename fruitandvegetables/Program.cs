using System;
using System.IO;

namespace fruitandvegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C:\Users\opilane\samples\fruit.txt";
            string[] veggiedata = File.ReadAllLines(fruitpath);

            string veggiepath = @"C:\Users\opilane\samples\veggie.txt";
            string[] fruitdata = File.ReadAllLines(veggiepath);

            File.WriteAllLines(fruitpath, fruitdata);
            File.WriteAllLines(veggiepath, veggiedata);

        }
    }
}
