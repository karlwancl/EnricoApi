using System;
using EnricoApi;

class Program
{
    static void Main(string[] args)
    {
        var enrico = Enrico.GetPublicHolidaysForYearAsync(2016, Country.UnitedStatesOfAmerica, Region.California).Result;
        var enrico2 = Enrico.GetPublicHolidaysForMonthAsync(2016, 1, Country.HongKong).Result;
        var enrico3 = Enrico.GetPublicHolidaysForDateRangeAsync(new DateTime(2016, 1, 1), DateTime.Now, Country.HongKong).Result;
        bool isTrue = Enrico.IsPublicHolidayAsync(new DateTime(2016, 1, 6), Country.HongKong).Result;
        Console.ReadLine();
    }
}