class Program
{
    static void Main()
    {
        var teamChat = new TeamChatRoom();

        var steve = new Developer("Steve");
        var justin = new Developer("Justin");
        var jenna = new Developer("Jenna");
        var kim = new Tester("Kim");
        var julia = new Tester("Julia");

        teamChat.RegisterMembers(steve, justin, jenna, kim, julia);

        steve.Send("Hello everyone, I'm Steve the new Developer!");
        kim.Send("Hi Steve! I'm Kim the new Tester.");

        steve.SendTo<Tester>("Make sure you are executing your Unit Test before checking in!");
    }
}
