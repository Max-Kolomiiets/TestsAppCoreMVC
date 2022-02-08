using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestsAppCoreMVC.Models
{
    public class Question : BaseModel
    {
        public string Name { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }
        public IList<Answer> Answers { get; set; }
    }
}
