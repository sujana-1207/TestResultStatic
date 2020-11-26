using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestResultService.Models;

namespace TestResultService.Repositories
{
    public class TestResultRepository:ITestResult
    {
        private static readonly List<TestResultTab> _testResults = new List<TestResultTab>()
        {
            new TestResultTab{ TestId=1,UserId=101,UserName="Moana",Result="Negative" },
            new TestResultTab{ TestId=2,UserId=102,UserName="Elsa",Result="Negative" },
            new TestResultTab{ TestId=3,UserId=103,UserName="Anna",Result="Positive" },
            new TestResultTab{ TestId=4,UserId=104,UserName="Ariel",Result="Negative" },
            new TestResultTab{ TestId=5,UserId=105,UserName="Aurora",Result="Positive" },
        };
        
        public List<TestResultTab> GetAll()
        {
            return _testResults;
        }
        public TestResultTab GetTestResult(int id)
        {
            var u = _testResults.Where(c => c.TestId == id).FirstOrDefault();
            return u;
        }
    }
}
