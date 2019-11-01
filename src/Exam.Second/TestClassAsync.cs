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
