using System;
using System.Reflection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am running...");
            Console.WriteLine(Assembly.GetCallingAssembly().FullName);
        }
    }
}
