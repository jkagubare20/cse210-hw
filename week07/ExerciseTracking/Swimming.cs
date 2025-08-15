using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int distance, int speed, int pace,int duration, int laps)
        : base(distance, speed, pace, duration)
    {
        _laps = laps;
    }
    public override decimal GetDistance()
    {
        _distance = _laps * 50m / 1000m; // Convert laps to kilometers
        return _distance;
    }

    public override decimal GetSpeed()
    {
        GetDistance();

        if (_duration > 0 && _distance > 0)
        {
            _speed = _distance / (_duration / 60m); // Speed in km/h
            return _speed;
        }
        return 0;
    }

    public override decimal GetPace()
    {
        GetDistance();
        if (_distance > 0)
        {
            _pace = _duration / _distance; // Pace in min/km
            return _pace;
        }
        return 0;
    }

    public override string GetSummary()
    {
        decimal distance = GetDistance();
        decimal speed = GetSpeed();
        decimal pace = GetPace();

        return $"{DateTime.Now.ToShortDateString()} - Swimming ({_duration} min, {_laps} laps): Distance: {distance} km, Speed: {speed} km/h, Pace: {pace} min/km";
    }
}