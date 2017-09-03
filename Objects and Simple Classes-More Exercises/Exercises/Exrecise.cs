namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Exrecise
    {
        private string topic;
        private string courseName;
        private string judgeContestLink;
        private List<string> problems;

        public string Topic 
        {
            get { return topic; }
            set { topic = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string JudgeContestLink
        {
            get { return judgeContestLink; }
            set { judgeContestLink = value; }
        }

        public List<string> Problems 
        {
            get { return problems; }
            set { problems = value; }
        }
     }
}
