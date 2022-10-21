using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int GetDateDifference(string startDateAsString, string endDateAsString)
        {
            //DateTime startDate = DateTime.Parse(startDateAsString);
            //DateTime endDate = DateTime.Parse(endDateAsString);

            DateTime firstDate = DateTime.ParseExact(startDateAsString, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(endDateAsString, "yyyy MM dd", CultureInfo.InvariantCulture);

            TimeSpan difference = firstDate - secondDate;

            return Math.Abs(difference.Days);            
        }
    }
}
