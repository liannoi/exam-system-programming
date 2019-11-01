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

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Second
{
    public class TestClassAsync
    {
        private readonly TestClass testClass;

        public TestClassAsync()
        {
            testClass = new TestClass();
        }

        public async Task<IEnumerable<double>> GetDataAsync()
        {
            return await Task.Factory.StartNew(testClass.GetData);
        }

        public async Task<IEnumerable<double>> GetFunctionSquereAsync(IEnumerable<double> source)
        {
            return await Task.Factory.StartNew(() =>
            {
                return testClass.GetFunctionSquere(source.ToList());
            });
        }

        public async Task<IEnumerable<double>> GetFunctionSinAsync(IEnumerable<double> source)
        {
            return await Task.Factory.StartNew(() =>
            {
                return testClass.GetFunctionSin(source.ToList());
            });
        }
    }
}
