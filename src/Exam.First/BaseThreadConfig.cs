using System.Threading;

namespace Exam.First
{
    public abstract class BaseThreadConfig
    {
        protected Thread thread;
        protected Test test;

        protected BaseThreadConfig()
        {
            test = new Test();
            thread = new Thread(Print);
        }

        public void BeginInvoke()
        {
            thread.Start();
        }

        public void EndInvoke()
        {
            thread.Abort();
        }

        protected abstract void Print();
    }
}
