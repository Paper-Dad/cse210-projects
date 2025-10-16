class Swimming : Activity
{
    private int _laps;
    private double _lapLengthMeters;

    public Swimming(string date, int durationMinutes, int laps, double lapLengthMeters = 50)
        : base(date, durationMinutes)
    {
        _laps = laps;
        _lapLengthMeters = lapLengthMeters;
    }

    public override double GetDistance() => (_laps * _lapLengthMeters) / 1000.0;

    public override double GetSpeed() => GetDistance() / (DurationMinutes / 60.0);

    public override double GetPace() => DurationMinutes / GetDistance();
}