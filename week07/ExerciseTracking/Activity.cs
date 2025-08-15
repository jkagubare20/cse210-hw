using System;
public abstract class Activity
{
    protected decimal _distance;
    protected decimal _speed;
    protected decimal _pace;
    protected decimal _duration;
    public Activity(int distance, int speed, int pace, int duration)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
        _duration = duration; // Initialize minutes to 0
    }

    public abstract decimal GetDistance();
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();

    public abstract string GetSummary();

} 