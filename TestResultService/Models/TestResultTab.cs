using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestResultService.Models
{
    public class TestResultTab
    {
        public int TestId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Result { get; set; }
    }
}
