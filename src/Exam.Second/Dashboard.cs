using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Second
{
    public partial class Dashboard : Form
    {
        private readonly TestClassAsync testClass;
        private CancellationTokenSource cancellationTokenSource;

        public CancellationToken CancellationToken => cancellationTokenSource?.Token ?? CancellationToken.None;


        public Dashboard()
        {
            InitializeComponent();
            testClass = new TestClassAsync();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void CancelTasks()
        {
            cancellationTokenSource.Cancel();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            CancelTasks();
            ListBoxHelper.ClearListBox(datasListBox);
            ListBoxHelper.ClearListBox(functionSqueresListBox);
            ListBoxHelper.ClearListBox(functionSinsListBox);
        }

        private void ParallelFillButton_Click(object sender, EventArgs e)
        {
            ReCreateToken();

            Task.Factory.StartNew(async () =>
            {
                await ListBoxHelper.FillListBoxAsync(datasListBox, testClass.GetDataAsync(), CancellationToken);
            });

            Task.Factory.StartNew(async () =>
            {
                await ListBoxHelper.FillListBoxAsync(functionSinsListBox, testClass.GetFunctionSinAsync(new List<double>
                {
                    1,2,3,4
                }), CancellationToken);
            });

            Task.Factory.StartNew(async () =>
            {
                await ListBoxHelper.FillListBoxAsync(functionSqueresListBox, testClass.GetFunctionSquereAsync(new List<double>
                {
                    1,2,3,4
                }), CancellationToken);
            });
        }

        private void ReCreateToken()
        {
            GC.SuppressFinalize(cancellationTokenSource);
            cancellationTokenSource = new CancellationTokenSource();
        }

        private async void SequentialFillButton_ClickAsync(object sender, EventArgs e)
        {
            ReCreateToken();
            await FillConsistentlyAsync();
        }

        private async Task FillConsistentlyAsync()
        {
            Task firstTask = ListBoxHelper.FillListBoxAsync(datasListBox, testClass.GetDataAsync(), CancellationToken);
            Task secondTask = await firstTask.ContinueWith(CompleteSecondAsync);
            Task thirdTask = await secondTask.ContinueWith(CompleteThirdAsync);
        }

        private async Task CompleteSecondAsync(Task task)
        {
            await ListBoxHelper.FillListBoxAsync(functionSqueresListBox, testClass.GetFunctionSquereAsync(new List<double>
            {
                1,2,3,4
            }), CancellationToken);
        }

        private async Task CompleteThirdAsync(Task task)
        {
            await ListBoxHelper.FillListBoxAsync(functionSinsListBox, testClass.GetFunctionSinAsync(new List<double>
            {
                1,2,3,4
            }), CancellationToken);
        }
    }
}
