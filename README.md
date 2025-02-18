# ndate
A .NET Core DateTime extension library. It will give us the facility to get any familiar date ranges such as current year, nth year, current month, last month etc. This will be very useful when you want to develop any Analytical Dashboard or Data Analytics application for these date ranges are often useful to build different reports, charts, figures etc.

## Available in NuGet
Install it via below command. Support added for .NET 8.
```
Install-Package NDate.Ext -Version 1.2.0
```

# Give it a STAR :star:
Loving this repository? Show your support by giving this project a star!


## returns type => DateRange {Start: DateTime, End: DateTime}

```
var date = DateTime.Today;
```

## CurrentYear()
Returns the current year range based on the provided datetime value.

```
var currentYear = date.CurrentYear();
Console.WriteLine("Current Year Start: " + currentYear.Start.ToString("yyyy-MM-dd") 
                                         + " - Current Year End:" 
                                         + currentYear.End.ToString("yyyy-MM-dd"));
```

## LastYear()
Returns the last year range based on the provided datetime value.

```
var lastYear = date.LastYear();
Console.WriteLine("Last Year Start: " + lastYear.Start.ToString("yyyy-MM-dd")
                                         + " - Last Year End:"
                                         + lastYear.End.ToString("yyyy-MM-dd"));
```

## NthYear()
Returns the nth year range based on the provided datetime value.

```
var fiveYearsAgo = date.NthYear(-5);
Console.WriteLine("5 Years Ago Start: " + fiveYearsAgo.Start.ToString("yyyy-MM-dd")
                                      + " - 5 Years Ago End:"
                                      + fiveYearsAgo.End.ToString("yyyy-MM-dd"));
```

## CurrentMonth()
Returns the current month range based on the provided datetime value.

```
var currentMonth = date.CurrentMonth();
Console.WriteLine("Current Month Start: " + currentMonth.Start.ToString("yyyy-MM-dd")
                                        + " - Current Month End:"
                                        + currentMonth.End.ToString("yyyy-MM-dd"));
```

## LastMonth()
Returns the last month range based on the provided datetime value.

```
var lastMonth = date.LastMonth();
Console.WriteLine("Last Month Start: " + lastMonth.Start.ToString("yyyy-MM-dd")
                                          + " - Last Month End:"
                                          + lastMonth.End.ToString("yyyy-MM-dd"));
```

## NthMonth()
Returns the nth month range based on the provided datetime value.

```
var fiveMonthAgo = date.NthMonth(-5);
Console.WriteLine("5 Months Ago Start: " + fiveMonthAgo.Start.ToString("yyyy-MM-dd")
                                       + " - 5 Months Ago End:"
                                       + fiveMonthAgo.End.ToString("yyyy-MM-dd"));
```

## CurrentWeek()
Returns the current week range based on the provided datetime value.

```
var currentWeek = date.CurrentWeek();
Console.WriteLine("Current Week Start: " + currentWeek.Start.ToString("yyyy-MM-dd")
                                          + " - Current Week End:"
                                          + currentWeek.End.ToString("yyyy-MM-dd"));
```

## LastWeek()
Returns the last week range based on the provided datetime value.

```
var lastWeek = date.LastWeek();
Console.WriteLine("Last Week Start: " + lastWeek.Start.ToString("yyyy-MM-dd")
                                       + " - Last Week End:"
                                       + lastWeek.End.ToString("yyyy-MM-dd"));
```

## NthWeek()
Returns the nth week range based on the provided datetime value.

```
var fiveWeekAgo = date.NthWeek(-5);
Console.WriteLine("5 Weeks Ago Start: " + fiveWeekAgo.Start.ToString("yyyy-MM-dd")
                                         + " - 5 Weeks Ago End:"
                                         + fiveWeekAgo.End.ToString("yyyy-MM-dd"));
```

## YTD()
Returns the year to date range based on the provided datetime value.

```
var ytd = date.YTD();
Console.WriteLine("YTD Start: " + ytd.Start.ToString("yyyy-MM-dd")
                                         + " - YTD End:"
                                         + ytd.End.ToString("yyyy-MM-dd"));
```

## QTD()
Returns the quarter to date range based on the provided datetime value.

```
var qtd = date.QTD();
Console.WriteLine("QTD Start: " + qtd.Start.ToString("yyyy-MM-dd")
                                + " - QTD End:"
                                + qtd.End.ToString("yyyy-MM-dd"));
```

## Q1()
Returns the 1st quarter range of the year based on the provided datetime value.

```
var q1 = date.Q1();
Console.WriteLine("Q1 Start: " + q1.Start.ToString("yyyy-MM-dd")
                                + " - Q1 End:"
                                + q1.End.ToString("yyyy-MM-dd"));
```

## Q2()
Returns the 2nd quarter range of the year based on the provided datetime value.

```
var q2 = date.Q2();
Console.WriteLine("Q2 Start: " + q2.Start.ToString("yyyy-MM-dd")
                               + " - Q2 End:"
                               + q2.End.ToString("yyyy-MM-dd"));
```

## Q3()
Returns the 3rd quarter range of the year based on the provided datetime value.

```
var q3 = date.Q3();
Console.WriteLine("Q3 Start: " + q3.Start.ToString("yyyy-MM-dd")
                               + " - Q3 End:"
                               + q3.End.ToString("yyyy-MM-dd"));
```

## Q4()
Returns the 4th quarter range of the year based on the provided datetime value.

```
var q4 = date.Q4();
Console.WriteLine("Q4 Start: " + q4.Start.ToString("yyyy-MM-dd")
                               + " - Q4 End:"
                               + q4.End.ToString("yyyy-MM-dd"));
```
## LastThirtyDays()

Returns the start and end date range of last thirty days.
```
var lastThirtyDays = date.LastThirtyDay();
Console.WriteLine("Last Thirty Days Start: " + lastThirtyDays.Start.ToString("yyyy-MM-dd")
                               + " - Last Thirty Days End:"
                               + lastThirtyDays.End.ToString("yyyy-MM-dd"));
```

## Yesterday()

Returns the start and end date range of Yesterday.
```
var yesterday = date.Yesterday();
Console.WriteLine("Yesterday Start: " + yesterday.Start.ToString("yyyy-MM-dd")
                               + " - Yesterday End:"
                               + yesterday.End.ToString("yyyy-MM-dd"));  
```

## Tomorrow()

Returns the start and end date range of tomorrow.
```
var tomorrow = date.Tomorrow();
Console.WriteLine("Tomorrow Start: " + tomorrow.Start.ToString("yyyy-MM-dd")
                               + " - Tomorrow End:"
                               + tomorrow.End.ToString("yyyy-MM-dd"));
```

Last Updated: 2025-02-19
