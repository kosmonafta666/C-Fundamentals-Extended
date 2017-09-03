namespace Japanese_Roulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JapaneseRoulette
    {
        public static void Main(string[] args)
        {
            //read the pistol;
            var pistol = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //read the player;
            var players = Console.ReadLine().Split(' ').ToArray();

            //bool for lucky players;
            bool luckyPlayers = true;

            //var to find where is the billet;
            var bullet = pistol.IndexOf(1);

            //var for current position;
            var position = 2;

            for (int i = 0; i < players.Length; i++)
            {
                //var for spin;
                var spin = int.Parse(players[i].Split(',')[0]);

                //var for direction;
                var direction = players[i].Split(',')[1];

                if (direction == "Left")
                {
                    while (spin > 0)
                    {
                        position++;
                        spin--;

                        if (position > 5)
                        {
                            position = 0;
                        }
                    }
                }
                else if (direction == "Right")
                {
                    while (spin > 0)
                    {
                        position--;
                        spin--;

                        if (position < 0)
                        {
                            position = 5;
                        }
                    }
                }//end of check for commands;

                if (position == bullet)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    luckyPlayers = false;
                    break;
                }

                position--;

            }//end of for loop

            if (luckyPlayers)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
