class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int durationMinutes, double distanceKm)
        : base(date, durationMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;

    public override double GetSpeed() => _distanceKm / (DurationMinutes / 60.0);

    public override double GetPace() => DurationMinutes / _distanceKm;
}