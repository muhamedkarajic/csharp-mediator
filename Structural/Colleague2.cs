using System;

public class Colleague2 : Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 recived Notification Message: {message}");
    }
}