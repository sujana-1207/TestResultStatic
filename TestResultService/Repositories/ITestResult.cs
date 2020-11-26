using System;
using System.Collections.Generic;
using System.Linq;
using TestResultService.Models;
using System.Threading.Tasks;

namespace TestResultService.Repositories
{
    public interface ITestResult
    {
        public List<TestResultTab> GetAll();
        public TestResultTab GetTestResult(int id);
    }
}
