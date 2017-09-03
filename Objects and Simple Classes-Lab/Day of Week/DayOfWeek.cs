namespace Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            //read the date;
            var date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            //var for date of the week;
            var dayOfWeek = date.DayOfWeek.ToString();

            //print thr result;
            Console.WriteLine(dayOfWeek);
        }
    }
}
