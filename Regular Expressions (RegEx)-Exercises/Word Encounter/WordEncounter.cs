namespace Word_Encounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main(string[] args)
        {
            //var filter sentence;
            var filterSentence = Console.ReadLine();
            //var for filter char;
            var filterChar = filterSentence[0];
            //var for filter count;
            var filterCount = int.Parse(filterSentence[1].ToString());

            //var regex object to validate sentence;
            var regexSentence = new Regex(@"[A-Z].+[.?!]");
            //var for srtring pattern for regex for words;
            var patternFilter = String.Format("{0}", filterChar);
            //var regex of filter word;
            var regexWord = new Regex(patternFilter);

            //list for matched words;
            var matchedWords = new List<string>();

            //var for sentence;
            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                //var to check if sentense is valid;
                var validSentence = regexSentence.IsMatch(sentence);

                if (validSentence && regexSentence.Match(sentence).Length == sentence.Length)
                {
                    //var to split senetence by words;
                    var token = new Regex(@"\b\w+\b");
                    //var for words in sentence;
                    var words = token.Matches(sentence);

                    foreach (Match word in words)
                    {
                        //var to check any occurrencies in word;
                        var wordOccurr = regexWord.Matches(word.Value);
                        
                        if (wordOccurr.Count >= filterCount)
                        {
                            matchedWords.Add(word.ToString().Trim());
                        }
                    }
                } 
           
                sentence = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            Console.WriteLine(string.Join(", ", matchedWords));
        }
    }
}
