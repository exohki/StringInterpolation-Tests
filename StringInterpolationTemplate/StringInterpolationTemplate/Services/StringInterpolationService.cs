using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }
    // 2. 2019.01.22
    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        Console.WriteLine(date);
        return date;
    }

    // 3. Day 22 of January, 2019
    public string Number03()
    {
        var date = $"Day {_date.Now.ToString("dd")} of {_date.Now.ToString("MMMM")}, {_date.Now.ToString("yyyy")}";
        Console.WriteLine(date);
        return date;
    }

    // 4. Year: 2019, Month: 01, Day: 22
    public string Number04()
    {
        var date = $"Year: {_date.Now.ToString("yyyy")}, Month: {_date.Now.ToString("MM")}, Day: {_date.Now.ToString("dd")}";
        Console.WriteLine(date);
        return date;
    }

    // 5. Tuesday (10 spaces total, right-aligned)
    public string Number05()
    {
        var dayOfWeek = _date.Now.ToString("dddd");
        var formattedDay = dayOfWeek.PadLeft(10);
        Console.WriteLine(formattedDay);
        return formattedDay;
    }

    // 6. 11:01 PM Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
    public string Number06()
    {
        var formattedTime = $"{_date.Now:hh:mm tt dddd}".PadLeft(10);
        Console.WriteLine(formattedTime);
        return formattedTime;
    }

    // 7. h:11, m:01, s:27
    public string Number07()
    {
        var formattedTime = $"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
        Console.WriteLine(formattedTime);
        return formattedTime;
    }

    // 8. 2019.01.22.11.01.27
    public string Number08()
    {
        var formattedDateTime = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
        Console.WriteLine(formattedDateTime);
        return formattedDateTime;
    }

    // 9. Output as currency
    public string Number09()
    {
        var pi = Math.PI;
        var formattedCurrency = pi.ToString("C");
        Console.WriteLine(formattedCurrency);
        return formattedCurrency;
    }

    // 10. Output as right-aligned (10 spaces), number with 3 decimal places
    public string Number10()
    {
        var pi = Math.PI;
        var formattedNumber = $"{pi,10:N3}";
        Console.WriteLine(formattedNumber);
        return formattedNumber;
    }

    public string Number11()
    {
        var yearHex = _date.Now.Year.ToString("X4");
        Console.WriteLine(yearHex);

        return yearHex;
    }

}