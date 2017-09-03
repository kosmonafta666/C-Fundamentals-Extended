namespace User_Logins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserLogins
    {
        public static void Main(string[] args)
        {
            //dictionary for users log;
            var userLogs = new Dictionary<string, string>();
            //var for unsuccesfull login;
            var unsuccessfullLogs = 0;

            while (true)
            {
                //var for input user and passsword;
                var input = Console.ReadLine();

                //end of while loop;
                if (input == "login")
                {
                    break;
                }
                
                //var for user;
                var user = input.Split(' ')[0];
                //var for pasword;
                var password = input.Split(' ')[2];

                //fill the user logs dictionary;
                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, password);
                }
                else
                {
                    userLogs[user] = password;
                }
            }//end of first while loop;

            while (true)
            {
                //var for log;
                var log = Console.ReadLine();

                //end of while loop;
                if (log == "end")
                {
                    break;
                }

                //var for user log;
                var userLog = log.Split(' ')[0];
                //var for user password;
                var userPassword = log.Split(' ')[2];

                //check for logins;
                if (userLogs.ContainsKey(userLog))
                {
                    if (userLogs[userLog] == userPassword)
                    {
                        Console.WriteLine("{0}: logged in successfully", userLog);
                    }
                    else
                    {
                        Console.WriteLine("{0}: login failed", userLog);
                        unsuccessfullLogs++;
                    }
                }
                else
                {
                    Console.WriteLine("{0}: login failed", userLog);
                    unsuccessfullLogs++;
                }
            }//end of second while loop;

            //print the unseccessfull logins;
            Console.WriteLine("unsuccessful login attempts: {0}", unsuccessfullLogs);
        }
    }
}
