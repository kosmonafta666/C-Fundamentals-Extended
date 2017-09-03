namespace JSON_Parse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string name;
        private int age;
        private List<int> grades;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<int> Grades
        {
            get { return grades; }
            set { grades = value; }
        }
    }
}
