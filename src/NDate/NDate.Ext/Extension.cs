using System;

namespace NDate.Ext
{
    public static class Extension
    {
        public static DateRange CurrentYear(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        public static DateRange LastYear(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year - 1, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        public static DateRange NthYear(this DateTime date, int n)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year - n, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }
    }
}
