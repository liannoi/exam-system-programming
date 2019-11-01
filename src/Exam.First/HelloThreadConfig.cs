using System.Threading;

namespace Exam.First
{
    public class HelloThreadConfig : BaseThreadConfig
    {
        public HelloThreadConfig() : base()
        {
        }

        protected override void Print()
        {
            while (true)
            {
                test.Method1();
                SharedItems.WaitHandler.Set();
                Thread.Sleep(200);
            }
        }
    }
}
