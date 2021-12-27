using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {

        [DllImport("Lib1", EntryPoint ="add", CharSet = CharSet.Auto)]
        static extern int Add(int a, int b);

        [DllImport("Lib1", EntryPoint = "max", CharSet = CharSet.Auto)]
        static extern int Max(int a, int b);

        static void Main(string[] args)
        {
            var result = Add(1, 2);
            Console.WriteLine(result);

            var max = Max(1, 2);
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
