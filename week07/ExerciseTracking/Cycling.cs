class Cycling : Activity
{
    private double _distanceKm;
    private double _elevationGain;

    public Cycling(string date, int durationMinutes, double distanceKm, double elevationGain)
        : base(date, durationMinutes)
    {
        _distanceKm = distanceKm;
        _elevationGain = elevationGain;
    }

    public override double GetDistance() => _distanceKm;

    public override double GetSpeed() => _distanceKm / (DurationMinutes / 60.0);

    public override double GetPace() => DurationMinutes / _distanceKm;
}