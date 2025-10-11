using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public string Name => _shortName;
    public string Description => _description;
    public string Points => _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    public abstract string GetStringRepresentation();

    public abstract int GetPointsForEvent();
}