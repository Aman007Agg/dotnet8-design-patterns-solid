using MediatorPattern;

class program
{
    static void Main()
    {
        ChatRoom room = new ChatRoom();
        User aman = new ChatUser(room, "Aman");
        User naman = new ChatUser(room, "Naman");
        User priyanka = new ChatUser(room, "Priyanka");

        room.AddUser(aman);
        room.AddUser(naman);
        room.AddUser(priyanka);

        aman.Send("Hello everyone!");
    }
}