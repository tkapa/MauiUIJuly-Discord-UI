using MauiUIJuly_Discord_UI.Model;

namespace MauiUIJuly_Discord_UI.Resources.MockData
{
    public class MockMessages
    {
        public MockMessages(MockUsers _users)
        {
            var userList = _users.FakeUsers;

            FakeMessages = new List<Message>
            {
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 9:20 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Marvelled bleak an that but obeisance upon late",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "Till so",
                    TimeStamp = "Today at 9:20 AM"
                },new Message
                {
                    User = userList[1],
                    ChatMessage = "Myself pondered bends all on once shaven soul gileadtell ungainly raven its i above raven soul sat and was devil",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 9:20 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Uilaga felleyn qui volek myth",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "La approchons face est vaincu surprise qu'elle mystérieux fait mon moqueur ce le voici hélas",
                    TimeStamp = "Today at 9:20 AM"
                },new Message
                {
                    User = userList[2],
                    ChatMessage = "La il manifestamente e accio accio giudice tanto e mentre cose senza che forza prieghi mortali mossa esser che essilio fuor dovendo né lui dell'occhio e son ancora noi colui donne le mortali e di sua il i esser manifestamente intendo merito di son porgere come sí",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[1],
                    ChatMessage = "Procuratori primo quella mortale dare",
                    TimeStamp = "Today at 9:20 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Parte prestasse a ora manifestamente bene convenevole discerniamo cose giudice da ammirabile cose quale la e beato oppinione e per forse al alle che purita cosa e alcun quale quegli!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "Lebens um stunden und meinem zu sage träne schatten selbst bringt die halbverklungnen geisterreich um walten zauberhauch meinem irren des",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[1],
                    ChatMessage = "Not too much",
                    TimeStamp = "Today at 10:41 AM"
                }
            };
        }

        public List<Message> FakeMessages;
    }
}
