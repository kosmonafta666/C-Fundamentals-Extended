namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Exercises
    {
        public static void Main(string[] args)
        {
            //var for list of excercises;
            var exercises = new List<Exrecise>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "go go go")
            {
                //var for splitted input;
                var token = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                //var for topic;
                var topic = token[0].Trim();
                //var for course name;
                var courseName = token[1].Trim();
                //var for judge conteest link;
                var judgeContestLink = token[2].Trim();
                //var for problems;
                var problems = token[3].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                //var for cuurent exercise object;
                var currentExercises = new Exrecise() 
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = new List<string>()
                };

                foreach (var str in problems)
                {
                    currentExercises.Problems.Add(str.Trim());
                }

                exercises.Add(currentExercises);

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var exercise in exercises)
            {
                //var for countint exercise;
                var countExcercise = 1;

                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);
                Console.WriteLine(string.Join("\n", exercise.Problems.Select(x => countExcercise++ + ". " + x)));
          
            }
        }
    }
}
