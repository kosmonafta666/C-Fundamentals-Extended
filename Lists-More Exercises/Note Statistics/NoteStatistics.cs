namespace Note_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NoteStatistics
    {
        public static void Main(string[] args)
        {
            //read the frequency, split and convert to double list;
            var frequency = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //list for nores;
            var notes = new List<string>();

            //list for naturals;
            var naturals = new List<string>();

            //list for sharps;
            var sharps = new List<string>();

            //fill the notes list;
            foreach (var freq in frequency)
            {
                var note = ConvertFrequency(freq);
                notes.Add(note);
            }

            //fill the naturals and sharps lists;
            foreach (var note in notes)
            {
                if (note.Length == 1)
                {
                    naturals.Add(note);
                }
                else if (note.Length == 2 && (char)note[1] == '#')
                {
                    sharps.Add(note);
                }
            }

            //var for sum of naturals;
            var naturalSum = 0.0;
            
            //sum the naturals;
            foreach (var nat in naturals)
            {
                naturalSum += ConvertNotes(nat);
            }

            //var for sharps sum;
            var sharpsSum = 0.0;

            //sum the sharps;
            foreach (var sh in sharps)
            {
                sharpsSum += ConvertNotes(sh);
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", naturalSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);
        }

        //method for convert from frequency to note;
        public static string ConvertFrequency(double frequency)
        {
            //var for note;
            var note = "";
           
                if (frequency == 261.63) 
                {
                    note = "C";
                }
                else if (frequency == 277.18) 
                {
                    note = "C#";
                }   
                else if (frequency == 293.66) 
                {
                    note = "D";
                }
                else if (frequency == 311.13) 
                {
                    note = "D#";
                }
                else if (frequency == 329.63) 
                {
                    note = "E";
                }
                else if (frequency == 349.23) 
                {
                    note = "F";
                }
                else if (frequency == 369.99)
                {
                    note = "F#";
                }
                else if (frequency == 392.00) 
                {
                    note = "G";
                }
                else if (frequency == 415.30) 
                {
                    note = "G#";
                }
                else if (frequency == 440.00) 
                {
                    note = "A";
                }
                else if (frequency == 466.16) 
                {
                    note = "A#";
                }
                else if (frequency == 493.88) 
                {
                     note = "B";
                }

                return note;
            }

        //method for convert from note to frequency;
        public static double ConvertNotes(string note)
        {
            //var for frequency;
            var frequency = 0.00;

            if (note == "C")
            {
                frequency = 261.63;
            }
            else if (note == "C#")
            {
                frequency = 277.18;
            }
            else if (note == "D")
            {
                frequency = 293.66;
            }
            else if (note == "D#")
            {
                frequency = 311.13;
            }
            else if (note == "E")
            {
                frequency = 329.63;
            }
            else if (note == "F")
            {
                frequency = 349.23;
            }
            else if (note == "F#")
            {
                frequency = 369.99;
            }
            else if (note == "G")
            {
                frequency = 392.00;
            }
            else if (note == "G#")
            {
                frequency = 415.30;
            }
            else if (note == "A")
            {
                frequency = 440.00;
            }
            else if (note == "A#")
            {
                frequency = 466.16;
            }
            else if (note == "B")
            {
                frequency = 493.88;
            }

            return frequency;
        }
    }
}
