using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dateStrings = new List<string>(new string[]
            {
                "01/09/2022",
                "02/09/2022",
                "05/09/2022",
                "06/09/2022",
                "07/09/2022",
                "10/09/2022",
                "11/09/2022",
                "15/09/2022",
                "16/09/2022"
            });

            List<DateTime> listOfDates = dateStrings
                .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .ToList();

            string[] inputRange = Console.ReadLine().Split();
            DateTime fromDate = Convert.ToDateTime(inputRange[0]);
            DateTime toDate = Convert.ToDateTime(inputRange[1]);

            //Console.WriteLine(fromDate);
            //Console.WriteLine(toDate);

            List<DateTime> filteredList = listOfDates.Where(x => x >= fromDate && x <= toDate).ToList();

            foreach (var date in filteredList)
            {
                Console.WriteLine(date.ToString());
            }

            //Console.WriteLine(String.Join(", ", filteredList));
            //List<DateTime> listOfDates = new List<DateTime>();
            //DateTime dateTime = DateTime.Now;

        }
    }
}
