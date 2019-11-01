using System;

namespace Exam.First
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            HelloThreadConfig helloThreadConfig = new HelloThreadConfig();
            WorldThreadConfig worldThreadConfig = new WorldThreadConfig();
            helloThreadConfig.BeginInvoke();
            worldThreadConfig.BeginInvoke();

            Console.ReadKey();
            Console.WriteLine();
            helloThreadConfig.EndInvoke();
            worldThreadConfig.EndInvoke();
        }
    }
}
