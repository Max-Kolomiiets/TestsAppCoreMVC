using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestsAppCoreMVC.Models
{
    public class Test : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Question> Questions { get; set; }
    }
}
