public class Customer
{
    public string Name;
    public bool IsMember = false;

    public Customer(string name)
    {
        Name = name;
    }

    public Customer(string name, bool isMember)
    {
        Name = name;
        IsMember = isMember;
    }

    public bool BecomeMember()
    {
        IsMember = true;
        return IsMember;
    }

    public bool RemoveMember()
    {
        IsMember = false;
        return IsMember;
    }

    public override string ToString()
    {
        if (IsMember)
        {
            return $$"""
                {{Name}} (Is a Member)
                """;
        }
        return Name;
    }
}