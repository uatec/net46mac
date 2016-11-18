using System;
using System.Reflection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Assembly.GetCallingAssembly().FullName);
        }
    }
}
