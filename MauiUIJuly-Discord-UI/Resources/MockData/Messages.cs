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
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
                },new Message
                {
                    User = userList[0],
                    ChatMessage = "Hey everyone!",
                    TimeStamp = "Today at 9:20 AM"
                },
                new Message
                {
                    User = userList[2],
                    ChatMessage = "What's going on today?",
                    TimeStamp = "Today at 10:23 AM"
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
