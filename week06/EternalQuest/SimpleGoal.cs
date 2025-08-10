public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            Console.WriteLine($"Goal '{GetShortName()}' completed! You earned {GetPoints()} points.");
            _isComplete = true;
        }
        else
        {
            Console.WriteLine($"Goal '{GetShortName()}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()}: {GetDescription()} (Points: {GetPoints()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}