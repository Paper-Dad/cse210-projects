using System;
using System.Collections.Generic;

abstract class Activity
{
    protected string _date;
    protected int _durationMinutes;

    public Activity(string date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public string Date
    {
        get { return _date; }
    }

    public int DurationMinutes
    {
        get { return _durationMinutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} - {GetType().Name} ({DurationMinutes} min): " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} km/h, " +
               $"Pace: {GetPace():0.00} min/km";
    }
}