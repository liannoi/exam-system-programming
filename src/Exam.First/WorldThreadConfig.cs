using System.Threading;

namespace Exam.First
{
    public class WorldThreadConfig : BaseThreadConfig
    {
        public WorldThreadConfig() : base()
        {
        }

        protected override void Print()
        {
            while (true)
            {
                SharedItems.WaitHandler.WaitOne();
                test.Method2();
                SharedItems.WaitHandler.Set();
                Thread.Sleep(200);
            }
        }
    }
}
