using System;
using NDate.Ext;

namespace NDate.Runnable
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Today;

            var currentYear = date.CurrentYear();
            Console.WriteLine("Current Year Start: " + currentYear.Start.ToString("yyyy-MM-dd") 
                                                     + " - Current Year End:" 
                                                     + currentYear.End.ToString("yyyy-MM-dd"));

            var lastYear = date.LastYear();
            Console.WriteLine("Last Year Start: " + lastYear.Start.ToString("yyyy-MM-dd")
                                                     + " - Last Year End:"
                                                     + lastYear.End.ToString("yyyy-MM-dd"));

            var fiveYearsAgo = date.NthYear(-5);
            Console.WriteLine("5 Years Ago Start: " + fiveYearsAgo.Start.ToString("yyyy-MM-dd")
                                                  + " - 5 Years Ago End:"
                                                  + fiveYearsAgo.End.ToString("yyyy-MM-dd"));

            var currentMonth = date.CurrentMonth();
            Console.WriteLine("Current Month Start: " + currentMonth.Start.ToString("yyyy-MM-dd")
                                                    + " - Current Month End:"
                                                    + currentMonth.End.ToString("yyyy-MM-dd"));

            var lastMonth = date.LastMonth();
            Console.WriteLine("Last Month Start: " + lastMonth.Start.ToString("yyyy-MM-dd")
                                                      + " - Last Month End:"
                                                      + lastMonth.End.ToString("yyyy-MM-dd"));

            var fiveMonthAgo = date.NthMonth(-5);
            Console.WriteLine("5 Months Ago Start: " + fiveMonthAgo.Start.ToString("yyyy-MM-dd")
                                                   + " - 5 Months Ago End:"
                                                   + fiveMonthAgo.End.ToString("yyyy-MM-dd"));

            var currentWeek = date.CurrentWeek();
            Console.WriteLine("Current Week Start: " + currentWeek.Start.ToString("yyyy-MM-dd")
                                                      + " - Current Week End:"
                                                      + currentWeek.End.ToString("yyyy-MM-dd"));

            var lastWeek = date.LastWeek();
            Console.WriteLine("Last Week Start: " + lastWeek.Start.ToString("yyyy-MM-dd")
                                                   + " - Last Week End:"
                                                   + lastWeek.End.ToString("yyyy-MM-dd"));

            var fiveWeekAgo = date.NthWeek(-5);
            Console.WriteLine("5 Weeks Ago Start: " + fiveWeekAgo.Start.ToString("yyyy-MM-dd")
                                                     + " - 5 Weeks Ago End:"
                                                     + fiveWeekAgo.End.ToString("yyyy-MM-dd"));

            var ytd = date.YTD();
            Console.WriteLine("YTD Start: " + ytd.Start.ToString("yyyy-MM-dd")
                                                     + " - YTD End:"
                                                     + ytd.End.ToString("yyyy-MM-dd"));

            var qtd = date.QTD();
            Console.WriteLine("QTD Start: " + qtd.Start.ToString("yyyy-MM-dd")
                                            + " - QTD End:"
                                            + qtd.End.ToString("yyyy-MM-dd"));

            var q1 = date.Q1();
            Console.WriteLine("Q1 Start: " + q1.Start.ToString("yyyy-MM-dd")
                                            + " - Q1 End:"
                                            + q1.End.ToString("yyyy-MM-dd"));

            var q2 = date.Q2();
            Console.WriteLine("Q2 Start: " + q2.Start.ToString("yyyy-MM-dd")
                                           + " - Q2 End:"
                                           + q2.End.ToString("yyyy-MM-dd"));

            var q3 = date.Q3();
            Console.WriteLine("Q3 Start: " + q3.Start.ToString("yyyy-MM-dd")
                                           + " - Q3 End:"
                                           + q3.End.ToString("yyyy-MM-dd"));

            var q4 = date.Q4();
            Console.WriteLine("Q4 Start: " + q4.Start.ToString("yyyy-MM-dd")
                                           + " - Q4 End:"
                                           + q4.End.ToString("yyyy-MM-dd"));

            Console.ReadKey(true);
        }
    }
}
