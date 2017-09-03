namespace Filter_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterBase
    {
        public static void Main(string[] args)
        {
            //dictionary for age of employee;
            var ageEmployee = new Dictionary<string, int>();
            //dictionary for salary of employee;
            var salaryEmployee = new Dictionary<string, double>();
            //var for position of employee;
            var positionEmployee = new Dictionary<string, string>();

            while(true)
            {
                //var for input;
                var input = Console.ReadLine();

                //break the while loop;
                if (input == "filter base")
                {
                    break;
                }

                //var for name of employee;
                var name = input.Split(' ')[0];
                //var for age;
                int age = 0;
                //var for salary;
                double salary = 0.0;
                //bool for parsed integer;
                var parsedInt = int.TryParse(input.Split(' ')[2], out age);
                //bool for parsed double;
                var parsedDouble = double.TryParse(input.Split(' ')[2], out salary);

                //fill the dictionaries;
                if (parsedInt)
                {
                    if (!ageEmployee.ContainsKey(name))
                    {
                        ageEmployee.Add(name, age);
                    }
                }
                else if (parsedDouble)
                {
                    if (!salaryEmployee.ContainsKey(name))
                    {
                        salaryEmployee.Add(name, salary);
                    }
                }
                else
                {
                    if (!positionEmployee.ContainsKey(name))
                    {
                        positionEmployee.Add(name, input.Split(' ')[2]);
                    }
                }

            }//end of while loop;

            //read the filter command;
            var filterCommand = Console.ReadLine();

            //check the command and print the result;
            if (filterCommand == "Position")
            {
                foreach (var item in positionEmployee)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Position: {0}", item.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (filterCommand == "Salary")
            {
                foreach (var item in salaryEmployee)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Salary: {0:F2}", item.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (filterCommand == "Age")
            {
                foreach (var item in ageEmployee)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Age: {0}", item.Value);
                    Console.WriteLine("====================");
                }
            }
        }//end of check filter command and printing;

    }
}
