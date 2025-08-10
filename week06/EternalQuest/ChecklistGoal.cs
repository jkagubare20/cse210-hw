public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName}: {GetDescription} (Points: {GetPoints}) - Completed: {_amountCompleted}/{_target} (Bonus: {_bonus})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName},{GetDescription},{GetPoints},{_amountCompleted},{_target},{_bonus}";
    }
}
