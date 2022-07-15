using CommunityToolkit.Mvvm.ComponentModel;
using MauiUIJuly_Discord_UI.Model;
using MauiUIJuly_Discord_UI.Resources.MockData;
using Microsoft.Toolkit.Mvvm.Input;

namespace MauiUIJuly_Discord_UI.ViewModel
{
    public partial class MainPageModel : ObservableObject
    {
        public MainPageModel(MockMessages _messages, MockUsers _users)
        {
            messageList = _messages.FakeMessages;
            users = _users.FakeUsers;
        }

        readonly List<User> users;

        [ObservableProperty]
        List<Message> messageList;

        [ObservableProperty]
        public string text;
    }
}
