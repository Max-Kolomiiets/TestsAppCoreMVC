using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestsAppCoreMVC.Models
{
    public class Answer : BaseModel
    {
        public string Name { get; set; }
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
