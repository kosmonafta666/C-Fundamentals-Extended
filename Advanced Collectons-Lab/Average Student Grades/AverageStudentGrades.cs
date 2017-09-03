namespace Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class AverageStudentGrades
    {
        public static void Main(string[] args)
        {
            //read the number of students;
            var numberOfStudents = int.Parse(Console.ReadLine());

            //dictionaries for student and grades;
            var students = new Dictionary<string, List<double>>();

            for (int i = 1; i <= numberOfStudents; i++) 
            {
                //var for input;
                var input = Console.ReadLine();
                //var for student name;
                var studentName = input.Split(' ')[0];
                //var for grade of a student;
                var grade = double.Parse(input.Split(' ')[1]);

                //fill the dictionary;
                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }//end of for loop;

            foreach (var item in students)
            {
                Console.Write("{0} -> ", item.Key);

                //var average grade;
                var averageGrade = item.Value.Average();

                foreach (var grade in item.Value)
                {
                    Console.Write("{0:F2} ", grade);
                }

                Console.WriteLine("(avg: {0:F2})", averageGrade);
            }

            Console.WriteLine();
        }
    }
}
