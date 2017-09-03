namespace Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TrackDownloader
    {
        public static void Main(string[] args)
        {
            //read the input,split and covert to list;
            var input = Console.ReadLine().Split().ToList();

            //var for tracklist;
            var trackList = new List<string>();

            //list for the result;
            var result = new List<string>();

            //var for commands;
            var commands = Console.ReadLine();

            //fill the tracklist;
            while (commands != "end")
            {
                trackList.Add(commands);

                commands = Console.ReadLine();
            }

            //fill the result;
            for (int i = 0; i < trackList.Count; i++)
            {
                if (CheckForTrack(trackList[i], input))
                {
                    result.Add(trackList[i]);
                }
            }

            //printing the result;
            foreach (var track in result.OrderBy(x => x))
            {
                Console.WriteLine(track);
            }
        }

        //method to check for black listed track;
        public static bool CheckForTrack(string track, List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (track.Contains(input[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
