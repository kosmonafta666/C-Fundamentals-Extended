namespace Capitalize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class CapitalizeWords
    {
        public static void Main(string[] args)
        {
            //var for input sentence;
            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                //array for splited sentence;
                var token = sentence.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '"', '\n', ']', '[', '{', '}', '-'}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < token.Length; i++ )
                {
                    //make current word to lower;
                    token[i] = token[i].ToLower();
                    //capilize current word;
                    token[i] = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(token[i]);
                }

                //printing the result;
                Console.WriteLine("{0}", string.Join(", ", token));

                sentence = Console.ReadLine();
            }
        }
    }
}
