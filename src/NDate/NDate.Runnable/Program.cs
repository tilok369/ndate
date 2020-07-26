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

            var lastYear = date.CurrentYear();
            Console.WriteLine("Last Year Start: " + lastYear.Start.ToString("yyyy-MM-dd")
                                                     + " - Last Year End:"
                                                     + lastYear.End.ToString("yyyy-MM-dd"));

            Console.ReadKey(true);
        }
    }
}
