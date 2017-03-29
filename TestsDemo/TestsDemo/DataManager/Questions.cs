using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsDemo.DataManager
{
   public class Questions
    {
        public string Question { get; set; }
        public List<Answers> AnswersList { get; set; }
    }

   public class Answers
    {
        public string _answer { get; set; }
        public bool TrueAnswer { get; set; }
    }
}
