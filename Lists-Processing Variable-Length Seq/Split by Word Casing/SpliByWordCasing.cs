namespace Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SpliByWordCasing
    {
        public static void Main(string[] args)
        {
            //read teh inpit, split and convert to list;
            var input = Console.ReadLine()
                .Split(new char[14] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //list for lower letters word;
            var lowerLetters = new List<string>();

            //var for upper letters word;
            var upperLetters = new List<string>();

            //var for mixed letters word;
            var mixedLetters = new List<string>();

            foreach (var word in input)
            {
                if (IsLower(word))
                {
                    lowerLetters.Add(word);
                }
                else if (IsUpper(word))
                {
                    upperLetters.Add(word);
                }
                else
                {
                    mixedLetters.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerLetters));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedLetters));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperLetters));
        }


        //method to check if leeter in word are only lower;
        public static bool IsLower(string word)
        {
            //bool for result;
            bool flag = false;

            //var for count of lower letter;
            var countLower = 0;

            foreach (char ch in word)
            {
                if (char.IsLower(ch))
                {
                    countLower++;
                }
            }

            if (countLower == word.Length)
            {
                flag = true;
            }

            return flag;
        }


        //method to check if leeter in word are only upper;
        public static bool IsUpper(string word)
        {
            //bool for result;
            bool flag = false;

            //var for count of lower letter;
            var countUpper = 0;

            foreach (char ch in word)
            {
                if (char.IsUpper(ch))
                {
                    countUpper++;
                }
            }

            if (countUpper == word.Length)
            {
                flag = true;
            }

            return flag;
        }
    }
}
