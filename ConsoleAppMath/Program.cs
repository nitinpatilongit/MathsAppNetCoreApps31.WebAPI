using System;
using MathsAppNetCoreApps31.WebAPI;
namespace ConsoleAppMath
{
    public class Program
    {
        public static Utilities objUtilities;
        static void Main(string[] args)
        {
            objUtilities = new Utilities();
            Console.WriteLine("Hello World!");
            int a = objUtilities.Add(2, 3);

        }
    }
}
