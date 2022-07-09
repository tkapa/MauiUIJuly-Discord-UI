using CommunityToolkit.Mvvm.ComponentModel;
using MauiUIJuly_Discord_UI.Model;
using MauiUIJuly_Discord_UI.Resources.MockData;

namespace MauiUIJuly_Discord_UI.ViewModel
{
    public partial class MainPageModel : ObservableObject
    {
        public MainPageModel(MockMessages _messages)
        {
            messageList = _messages.FakeMessages;
        }

        public List<Message> messageList { get; set; }

        public string text { get; set; }
    }
}
