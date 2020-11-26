using NUnit.Framework;
using TestResultService.Repositories;
using TestResultService.Models;

namespace TestResultServiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TestResultRepository rep = new TestResultRepository();
            var u = rep.GetTestResult(1);
            var e = new TestResultTab { TestId = 1, UserId = 101, UserName = "Moana", Result = "Negative" };
            Assert.AreEqual(e.UserId,u.UserId);
            Assert.AreEqual(u.UserName, e.UserName);
            Assert.AreEqual(u.TestId, e.TestId);
            Assert.AreEqual(u.Result, e.Result);
        }
    }
}