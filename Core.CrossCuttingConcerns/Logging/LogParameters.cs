namespace Core.CrossCuttingConcerns.Logging;

public class LogParameters
{
    public string Name { get; set; }
    public object Value { get; set; }
    public string Type { get; set; }

    public LogParameters()
    {
        Name = string.Empty;
        Value = string.Empty;
        Type = string.Empty;
    }

    public LogParameters(string name, object value, string type)
    {
        Name = name;
        Value = value;
        Type = type;
    }
}