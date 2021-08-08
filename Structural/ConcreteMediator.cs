using System.Collections.Generic;
using System.Linq;

public class ConcreteMediator : Mediator
{
    private List<Colleague> collegues = new List<Colleague>();

    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        collegues.Add(colleague);
    }

    public T CreateCollegue<T>() where T : Colleague, new()
    {
        var c = new T();
        c.SetMediator(this);
        collegues.Add(c);
        return c;
    }

    public override void Send(string message, Colleague collegue)
    {
        collegues
            .Where(c => c != collegue)
            .ToList()
            .ForEach(c => c.HandleNotification(message));
    }
}