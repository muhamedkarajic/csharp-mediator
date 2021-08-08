using System;

public abstract class TeamMember
{
    private ChatRoom chatRoom;

    public TeamMember(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    internal void SetChatRoom(ChatRoom chatRoom)
    {
        this.chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        chatRoom.Send(Name, message);
    }

    public virtual void Recive(string from, string message)
    {
        Console.WriteLine($"From {from}: '{message}'");
    }

    public void SendTo<T>(string message) where T : TeamMember
    {
        chatRoom.SendTo<T>(Name, message);
    }
}