// Copyright 2019 Maksym Liannoi
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
            if (listBox == null)
            {
                throw new ArgumentNullException(nameof(listBox));
            }

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
            }, cancellationToken).ConfigureAwait(false);
        }
    }
}
