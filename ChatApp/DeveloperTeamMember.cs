using System;

public class Developer : TeamMember
{
    private ChatRoom chatRoom;

    public Developer(string name) : base(name) { }

    public override void Recive(string from, string message)
    {
        Console.Write($"{nameof(Developer)} {Name} has recived: ");
        base.Recive(from, message);
    }
}