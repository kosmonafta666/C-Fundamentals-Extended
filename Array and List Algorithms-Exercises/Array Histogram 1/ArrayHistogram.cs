namespace Array_Histogram_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayHistogram
    {
        static void Main(string[] args)
        {
            //read the input and splited to string array;
            var input = Console.ReadLine().Split(' ').ToList();

            //list for words;
            var words = new List<string>();

            //list for ocurencies;
            var occurList = new List<int>();

            //fill the words list and occur list;
            foreach (var word in input)
            {
                if (!words.Contains(word))
                {
                    words.Add(word);
                    occurList.Add(1);
                }
                else
                {
                    //var for index of the word;
                    var index = words.IndexOf(word);
                    occurList[index]++;
                }
            }

            //bubble sort algoritm;
            //bool for check if have any swaping;
            bool swap = true;
            
            while (swap)
            {
                swap = false;

                //var for temp value for occur list;
                var tempOccur = 0;
                //var for temp value for words list;
                var tempWord = "";

                for (int i = 1; i < occurList.Count; i++)
                {
                    if (occurList[i] > occurList[i - 1])
                    {
                        //swap the occur values;
                        tempOccur = occurList[i - 1];
                        occurList[i - 1] = occurList[i];
                        occurList[i] = tempOccur;

                        //swap the words value;
                        tempWord = words[i - 1];
                        words[i - 1] = words[i];
                        words[i] = tempWord;

                        swap = true;
                    }
                }//end of inner for loop;
            }//end of while loop;

            for (int i = 0; i < words.Count; i++)
            {
                //var for percent;
                var percent = (occurList[i] * 100.00) / input.Count;

                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], occurList[i], percent);
            }
        }
    }
}
