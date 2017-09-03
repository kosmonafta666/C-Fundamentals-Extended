namespace JSON_Parse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JSONParse
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var inputString = Console.ReadLine()
                .TrimStart(new[] { '[' , '{'})
                .TrimEnd(new[] { ']' , '}'})
                .Split(new[] {"},{"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //list for studend onbects;
            var students = new List<Student>();

            foreach (var str in inputString)
            {
                //var for spited in string in input strings;
                var splitSting = str.Split(new[] { ',', ':', '"', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                //var for student name;
                var name = splitSting[1];
                //var forstudent age;
                var age = int.Parse(splitSting[3]);

                //var for current student;
                var currentStudent = new Student()
                {
                    Name = name,
                    Age = age,
                    Grades = new List<int>()
                };

                //check if any grades and fill the grade list;
                if (splitSting.Length > 5)
                {
                    for (int i = 5; i < splitSting.Length; i++)
                    {
                        currentStudent.Grades.Add(int.Parse(splitSting[i].Trim()));
                    }
                }

                //add current student to students list;
                students.Add(currentStudent);
               
            }

            //printing the result;
            foreach (var student in students)
            {
                if (student.Grades.Count > 0)
                {
                    Console.WriteLine("{0} : {1} -> {2}", student.Name, student.Age, string.Join(", ", student.Grades));
                }
                else
                {
                    Console.WriteLine("{0} : {1} -> {2}", student.Name, student.Age, "None");
                }
            }
            
        }
    }
}
