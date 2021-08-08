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

    public override void Send(string message, Colleague collegue)
    {
        collegues
            .Where(c => c != collegue)
            .ToList()
            .ForEach(c => c.HandleNotification(message));
    }
}