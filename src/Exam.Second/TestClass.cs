// Copyright 2020 Maksym Liannoi
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

namespace Exam.Second
{
    public class TestClass
    {
        public List<double> GetData()
        {
            Thread.Sleep(5000);
            return new List<double>(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        public List<double> GetFunctionSquere(List<double> source)
        {
            Thread.Sleep(5000);
            List<double> collection = new List<double>();
            foreach (double item in source)
            {
                collection.Add(Math.Pow(item, 2));
            }

            return collection;
        }

        public List<double> GetFunctionSin(List<double> source)
        {
            Thread.Sleep(5000);
            List<double> collection = new List<double>();
            foreach (double item in source)
            {
                collection.Add(item * Math.Sin(item));
            }

            return collection;
        }
    }
}
