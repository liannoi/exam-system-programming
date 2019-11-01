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
            foreach (var item in source)
            {
                collection.Add(Math.Pow(item, 2));
            }

            return collection;
        }

        public List<double> GetFunctionSin(List<double> source)
        {
            Thread.Sleep(5000);
            List<double> collection = new List<double>();
            foreach (var item in source)
            {
                collection.Add(item * Math.Sin(item));
            }

            return collection;
        }
    }

}
