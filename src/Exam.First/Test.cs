using System;
using System.Threading;

namespace Exam.First
{
    public class Test
    {
        public void Method1()
        {
            Thread.Sleep(500);
            Console.Write("Hello");
            return;
        }

        public void Method2()
        {
            Thread.Sleep(500);
            Console.Write(" world");
            Console.WriteLine();
        }
    }

}
