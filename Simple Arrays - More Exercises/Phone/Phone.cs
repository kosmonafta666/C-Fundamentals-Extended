namespace Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Phone
    {
        public static void Main(string[] args)
        {
            //read the numbers;
            var numbers = Console.ReadLine().Split(' ').ToArray();

            //read the names;
            var names = Console.ReadLine().Split(' ').ToArray();

            //var for commands;
            var commands = Console.ReadLine();

            while (commands != "done")
            {
                //var for command1;
                var command1 = commands.Split(' ')[0];

                //var for command2;
                var command2 = commands.Split(' ')[1];

                //execute the command;
                ExecuteCommands(command1, command2, numbers, names);

                //checking the result of the commands;
                CheckCommands(command1, command2, numbers, names);

                commands = Console.ReadLine();
            }
        }

        


        //execute the commands;
        public static void ExecuteCommands(string command1, string command2, string[] numbers, string[] names)
        {
            //bool for command2(whether number or name);
            bool flag = true;

            //check if command2 is number or name;
            if (names.Contains(command2))
            {
                flag = true;
            }
            else if (numbers.Contains(command2))
            {
                flag = false;
            }

            switch (command1)
            {
                case "call":
                    if (flag == true)
                    {
                        //var for finding the index of name;
                        var indexName = Array.IndexOf(names, command2);
                        Console.WriteLine("calling {0}...", numbers[indexName]);
                    }
                    else if (flag == false)
                    {
                        //var for finding the index of number;
                        var indexName = Array.IndexOf(numbers, command2);
                        Console.WriteLine("calling {0}...", names[indexName]);
                    }
                    break;
                case "message":
                    if (flag == true)
                    {
                        //var for finding the index of name;
                        var indexName = Array.IndexOf(names, command2);
                        Console.WriteLine("sending sms to {0}...", numbers[indexName]);
                    }
                    else if (flag == false)
                    {
                        //var for finding the index of number;
                        var indexName = Array.IndexOf(numbers, command2);
                        Console.WriteLine("sending sms to {0}...", names[indexName]);
                    }
                    break;
            }
        }

        public static void CheckCommands(string command1, string command2, string[] numbers, string[] names)
        {
            //var for finding the index of number;
            var indexNumber = 0;

            if (names.Contains(command2))
            {
                indexNumber = Array.IndexOf(names, command2);
            }
            else if (numbers.Contains(command2))
            {
                indexNumber = Array.IndexOf(numbers, command2);
            }

            //var for number;
            var number = numbers[indexNumber];

            if (command1 == "call")
            {
                //var for summed digid of a number;
                var summedDigid = SummedOrDifferenceDigit(number, true);

                if (summedDigid % 2 != 0)
                {
                    Console.WriteLine("no answer");
                }
                else if (summedDigid % 2 == 0)
                {
                    //var for minutes;
                    int minutes = (int)summedDigid / 60;
                    int seconds = (int)summedDigid % 60;
                    Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
                }
            }
            else if (command1 == "message")
            {
                //var for difference of digit of a number;
                var differenceDigit = SummedOrDifferenceDigit(number, false);

                if (differenceDigit % 2 != 0)
                {
                    Console.WriteLine("busy");
                }
                else if (differenceDigit % 2 == 0)
                {
                    Console.WriteLine("meet me there");
                }
            }

        }

        //method for to sum or difference digit of a number;
        public static double SummedOrDifferenceDigit(string number, bool flag)
        {
            //var for result;
            var result = 0.0;

            foreach (char ch in number)
            {
                if (char.IsDigit(ch))
                {
                    if (flag == true)
                    {
                        result += char.GetNumericValue(ch);
                    }
                    else if (flag == false)
                    {
                        result -= char.GetNumericValue(ch);
                    }
                }
            }

            return result;
        }
    }
}
