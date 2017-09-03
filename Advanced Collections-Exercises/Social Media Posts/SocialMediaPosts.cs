namespace Social_Media_Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SocialMediaPosts
    {
        public static void Main(string[] args)
        {
            //var for reading the input;
            var input = Console.ReadLine();
            //dictionary for result;
            var result = new Dictionary< string, Dictionary<string, List<string>> >();

            while (input != "drop the media")
            {
                //var splited input;
                var token = input.Split(' ').ToArray();
                //var for command;
                var command = token[0];
                //var for post name;
                var postName = token[1];

                //check for commands;
                if (command == "post")
                {
                    if (!result.ContainsKey(postName))
                    {
                        result[postName] = new Dictionary<string, List<string>>();
                        result[postName]["like"] = new List<string>();
                        result[postName]["dislike"] = new List<string>();
                    }
                }
                else if (command == "like")
                {
                    result[postName]["like"].Add("like");
                }
                else if (command == "dislike")
                {
                    result[postName]["dislike"].Add(command);
                }
                else if (command == "comment")
                {
                    //var for writer;
                    var writer = token[2];
                    //var for comment;
                    var comment = input.Substring(token[0].Length + token[1].Length + token[2].Length + 3);

                    if (!result[postName].ContainsKey(writer))
                    {
                        result[postName][writer] = new List<string>();
                    }

                    result[postName][writer].Add(comment);
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var item in result)
            {
                //var for likes in post;
                var likes = item.Value["like"];
                //var for dislike in post;
                var dislikes = item.Value["dislike"];

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", item.Key, likes.Count, dislikes.Count);

                Console.WriteLine("Comments:");

                //check for commnets;
                if (item.Value.Count == 2)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var writer in item.Value)
                    {
                        if (writer.Key != "like" && writer.Key != "dislike")
                        {
                            foreach (var comment in writer.Value)
                            {
                                Console.WriteLine("*  {0}: {1}", writer.Key, comment);
                            }
                        }
                    }
                }
            }//end of printing;
        }
    }
}
