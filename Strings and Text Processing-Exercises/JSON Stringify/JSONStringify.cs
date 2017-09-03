namespace JSON_Stringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JSONStringify
    {
        public static void Main(string[] args)
        {
            //list for students objects;
            var students = new List<Student>();

            //var for input string;
            var input = Console.ReadLine();

            while (input != "stringify")
            {
                //var for splitted input;
                var token = input.Trim().Split(new[] { ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                //var for name of the current student;
                var name = token[0].Trim();
                //var for age of the current student;
                var age = int.Parse(token[1].Trim());
                //var for grades of the current student;
                List<int> grades = new List<int>();
                if (token.Length > 2)
                {
                    grades = token[2]
                        .Trim()
                        .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                }
                
                //var for current student;
                var curretStudent = new Student()
                {
                    Name = name,
                    Age = age,
                    Grades = new List<int>()
                };
                //fill the grade list of the current student;
                foreach (var grade in grades) 
                {
                    curretStudent.Grades.Add(grade);
                }

                students.Add(curretStudent);

                input = Console.ReadLine();
            }

            //list for JSON strings of the students;
            var listString = new List<string>();

            //creating the JSON string for every student and adding to list of JSON strings;
            foreach (var student in students)
            {
                var currentString = String.Format( "{{name:\"{0}\",age:{1},grades:[{2}]}}", student.Name, student.Age, string.Join(", ", student.Grades) );
                listString.Add(currentString);
            }

            //printing the result;
            Console.WriteLine("[{0}]", string.Join(",", listString));
        }
    }
}
