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
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = DateTime.Now.AddMinutes(-20)
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = DateTime.Now.AddMinutes(-7)
                },
                new Message
                {
                    User = userList[1],
                    ChatMessage = "Not too much",
                    TimeStamp = DateTime.Now.AddMinutes(-1)
                }
            };
        }

        public List<Message> FakeMessages;
    }
}
