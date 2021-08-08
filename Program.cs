class Program
{
    static void Main()
    {
        var mediator = new ConcreteMediator();

        var c1 = mediator.CreateCollegue<Colleague1>();
        var c2 = mediator.CreateCollegue<Colleague2>();

        c1.Send("Hello World! (from c1)");
        c2.Send("Hi! (from c2)");
    }
}
