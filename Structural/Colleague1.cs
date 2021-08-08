using System;

public class Colleague1 : Colleague
{
    public Colleague1(Mediator mediator) : base(mediator) { }

    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague1 recived Notification Message: {message}");
    }
}