using System;
public class Running : Activity
{

    public Running(int distance, int speed, int pace, int duration)
        : base(distance, speed, pace, duration)
    {
        _duration = duration;
    }

    public override decimal GetDistance()
    {
        _distance = (_duration / 60m) * _speed; // Calculate distance based on speed and duration
        return _distance;
    }

    public override decimal GetSpeed()
    {
        GetDistance(); 
        _speed = _distance / (_duration / 60m); // Speed in km/h
        return _speed;

    }

    public override decimal GetPace()
    {
        GetDistance(); 
        _pace = _duration / _distance; // Pace in min/km
        return _pace;
    }

    public override string GetSummary()
    {
        decimal distance = GetDistance();
        decimal speed = GetSpeed(); 
        decimal pace = GetPace();

        return $"{DateTime.Now.ToShortDateString()} - Running ({_duration} min): Distance: {_distance} km, Speed: {_speed} km/h, Pace: {_pace} min/km";
    }

}