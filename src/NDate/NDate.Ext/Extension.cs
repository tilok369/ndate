using System;

namespace NDate.Ext
{
    public static class Extension
    {
        /// <summary>
        /// Get the current year range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of current year</returns>
        public static DateRange CurrentYear(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the last year range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of last year</returns>
        public static DateRange LastYear(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year - 1, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the nth year range based on provided date and value of n
        /// </summary>
        /// <param name="date"></param>
        /// <param name="n"></param>
        /// <returns>start and end date of nth year</returns>
        public static DateRange NthYear(this DateTime date, int n)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year - n, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the current month range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of current month</returns>
        public static DateRange CurrentMonth(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year, date.Month, 1);
            range.End = range.Start.AddMonths(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the last month range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of last month</returns>
        public static DateRange LastMonth(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = (new DateTime(date.Year, date.Month, 1)).AddMonths(-1);
            range.End = range.Start.AddMonths(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the nth month range based on provided date and value of n
        /// </summary>
        /// <param name="date"></param>
        /// <param name="n"></param>
        /// <returns>start and end date of nth month</returns>
        public static DateRange NthMonth(this DateTime date, int n)
        {
            DateRange range = new DateRange();

            range.Start = (new DateTime(date.Year, date.Month, 1)).AddMonths(-1);
            range.End = range.Start.AddMonths(1).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the current week range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of current week</returns>
        public static DateRange CurrentWeek(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = date.Date.AddDays(-(int)date.DayOfWeek);
            range.End = range.Start.AddDays(7).AddSeconds(-1);

            return range;
        }

        /// <summary>
        /// Get the last week range based on provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of last week</returns>
        public static DateRange LastWeek(this DateTime date)
        {
            DateRange range = date.CurrentWeek();

            range.Start = range.Start.AddDays(-7);
            range.End = range.End.AddDays(-7);

            return range;
        }

        /// <summary>
        /// Get the nth week range based on provided date and the value of n
        /// </summary>
        /// <param name="date"></param>
        /// <param name="n"></param>
        /// <returns>start and end date of nth week</returns>
        public static DateRange NthWeek(this DateTime date, int n)
        {
            DateRange range = date.CurrentWeek();

            range.Start = range.Start.AddDays(n * 7);
            range.End = range.End.AddDays(n * 7);

            return range;
        }

        /// <summary>
        /// Get the year to date range value based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of year to date (YTD)</returns>
        public static DateRange YTD(this DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = (new DateTime(date.Year, 1, 1));
            range.End = (new DateTime(date.Year, date.Month, date.Day)).AddHours(23).AddMinutes(59).AddSeconds(59);

            return range;
        }

        /// <summary>
        /// Get the quarter to date range value based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of quarter to date (QTD)</returns>
        public static DateRange QTD(this DateTime date)
        {
            DateRange range = new DateRange();

            if (date.Month >= 1 && date.Month <= 3)
                range.Start = new DateTime(date.Year, 1, 1);
            else if (date.Month >= 4 && date.Month <= 6)
                range.Start = new DateTime(date.Year, 4, 1);
            else if (date.Month >= 7 && date.Month <= 9)
                range.Start = new DateTime(date.Year, 7, 1);
            else
                range.Start = new DateTime(date.Year, 10, 1);
            range.End = date;
            return range;
        }

        /// <summary>
        /// Get the 1st quarter range of the year based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of 1st quarter</returns>
        public static DateRange Q1(this DateTime date)
        {
            return new DateRange
            {
                Start = new DateTime(date.Year, 1, 1),
                End = new DateTime(date.Year, 4, 1).AddSeconds(-1)
            };
        }

        /// <summary>
        /// Get the 2nd quarter range of the year based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of 2nd quarter</returns>
        public static DateRange Q2(this DateTime date)
        {
            return new DateRange
            {
                Start = new DateTime(date.Year, 4, 1),
                End = new DateTime(date.Year, 7, 1).AddSeconds(-1)
            };
        }

        /// <summary>
        /// Get the 3rd quarter range of the year based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of 3rd quarter</returns>
        public static DateRange Q3(this DateTime date)
        {
            return new DateRange
            {
                Start = new DateTime(date.Year, 7, 1),
                End = new DateTime(date.Year, 10, 1).AddSeconds(-1)
            };
        }

        /// <summary>
        /// Get the 4th quarter range of the year based on the provided date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>start and end date of 4th quarter</returns>
        public static DateRange Q4(this DateTime date)
        {
            return new DateRange
            {
                Start = new DateTime(date.Year, 10, 1),
                End = new DateTime(date.Year + 1, 1, 1).AddSeconds(-1)
            };
        }
    }
}
