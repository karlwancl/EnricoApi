# EnricoApi
[Enrico Service](http://www.kayaposoft.com/enrico/) is a free service written in PHP providing public holidays for several countries. This library is a .NET wrapper to the Enrico Service, based on .NET standard 1.4.

### Features
* Get public holidays on various countries including USA, HK, China, etc through [Enrico Service](http://www.kayaposoft.com/enrico/)
* Determine if the given day is a holiday to the country

### Notes
[Enrico Service](http://www.kayaposoft.com/enrico/) has provided us a great free service to query holidays from various countries. Please give your love by making a donation to them if you find the service useful =)

### Supported Platforms
* .NET Core 1.0
* .NET Framework 4.6.1 or above
* Xamarin.iOS
* Xamarin.Android
* Universal Windows Platform

### How To Install
You can find the package through Nuget

	PM> Install-Package EnricoApi

### How To Use

#### Get public holidays by year

    var list = await Enrico.GetPublicHolidaysForYearAsync(2016, Country.HongKong);
    foreach (var holiday in list)
    {
        Console.WriteLine($"Date: {holiday.DateTime}, Local Name: {holiday.LocalName}, English Name: {holiday.EnglishName}");
    }

#### Get public holidays by month

    var list = await Enrico.GetPublicHolidaysForMonthAsync(2016, 1, Country.HongKong);
    foreach (var holiday in list)
    {
        Console.WriteLine($"Date: {holiday.DateTime}, Local Name: {holiday.LocalName}, English Name: {holiday.EnglishName}");
    }

#### Get public holidays within a date range

    var list = await Enrico.GetPublicHolidaysForDateRangeAsync(new DateTime(2016, 1, 1), DateTime.Now, Country.HongKong);
    foreach (var holiday in list)
    {
        Console.WriteLine($"Date: {holiday.DateTime}, Local Name: {holiday.LocalName}, English Name: {holiday.EnglishName}");
    }

#### Determine if a given day is a holiday
    bool isHoliday = await Enrico.IsPublicHolidayAsync(new DateTime(2016, 1, 1), Country.HongKong);

### Powered by
* [Flurl](https://github.com/tmenier/Flurl) ([@tmenier](https://github.com/tmenier)) - A simple & elegant fluent-style REST api library 

### License
This library is under [MIT License](https://github.com/salmonthinlion/EnricoApi/blob/master/LICENSE)

### Reference
[Enrico API Reference](http://www.kayaposoft.com/enrico/json/)