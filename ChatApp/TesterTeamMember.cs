using System;

public class Tester : TeamMember
{
    private ChatRoom chatRoom;

    public Tester(string name) : base(name) { }

    public override void Recive(string from, string message)
    {
        Console.Write($"{nameof(Tester)} {Name} has recived: ");
        base.Recive(from, message);
    }
}