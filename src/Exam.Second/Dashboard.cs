﻿// Copyright 2020 Maksym Liannoi
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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
            cancellationTokenSource.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private async void SequentialFillButton_Click(object sender, EventArgs e)
        {
            ReCreateToken();
            await FillConsistentlyAsync().ConfigureAwait(false);
        }

        private async Task FillConsistentlyAsync()
        {
            Task firstTask = ListBoxHelper.FillListBoxAsync(datasListBox, testClass.GetDataAsync(), CancellationToken);
            Task secondTask = await firstTask.ContinueWith(CompleteSecondAsync).ConfigureAwait(false);
            await secondTask.ContinueWith(CompleteThirdAsync).ConfigureAwait(false);
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
