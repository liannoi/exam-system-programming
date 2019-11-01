using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Second
{
    public static class ListBoxHelper
    {
        public static void ClearListBox(ListBox listBox)
        {
            listBox.Items.Clear();
        }

        public static async Task FillListBoxAsync(ListBox listBox, Task<IEnumerable<double>> objects, CancellationToken cancellationToken)
        {
            await Task.Factory.StartNew(() =>
            {
                objects.Result.ToList().ForEach(e =>
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    listBox.Items.Add(e);
                    Thread.Sleep(500);
                });
            }, cancellationToken);
        }
    }
}
