public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description)
    {
    }

    public override void RecordEvent()
    {
    
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName}: {GetDescription} (Points: {GetPoints}) - This goal is eternal.";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName},{GetDescription},{GetPoints}";
    }
}
