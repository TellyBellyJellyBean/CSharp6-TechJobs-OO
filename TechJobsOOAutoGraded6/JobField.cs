namespace TechJobsOOAutoGraded6;

// What fields do ALL FOUR of the classes have in common?
// - all four classes have an id
// - all four classes override tostring()
// - all four classes have a equality and HashCode check

// Which constructors are the same in ALL FOUR classes?
// - id and nextid, return string value, override to string are the exact same

// Which custom methods are identical in ALL of the classes?
// - tostring() constructor is identitical in all classes
// - return object constructor is same

public abstract class JobField
{
    public int Id { get; }
    private static int nextId = 1;
    public string Value { get; set; }

    public JobField()
    {
        Id = nextId;
        nextId++;
    }

    public JobField(string value) : this()
    {
        Value = value;

    }
    public override string ToString()
    {
        return Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is JobField type &&
               Id == type.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }



}
