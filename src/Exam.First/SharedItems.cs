using System.Threading;

namespace Exam.First
{
    public static class SharedItems
    {
        public static AutoResetEvent WaitHandler { get; } = new AutoResetEvent(false);
    }
}
