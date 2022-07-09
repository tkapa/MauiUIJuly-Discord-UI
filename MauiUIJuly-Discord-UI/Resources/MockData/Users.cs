using MauiUIJuly_Discord_UI.Model;

namespace MauiUIJuly_Discord_UI.Resources.MockData
{
    public class MockUsers
    {
        public List<User> FakeUsers = new List<User>
        {
            new User
            {
                UserId = 0,
                Name = "SSW-Kapa",
                ProfilePictureLink = "https://better-default-discord.netlify.app/Icons/Gradient-Red.png"
            },
            new User
            {
                UserId = 1,
                Name = "SSW-Jack",
                ProfilePictureLink = "https://better-default-discord.netlify.app/Icons/Gradient-Violet.png"
            },
            new User
            {
                UserId = 2,
                Name = "SSW-Brady",
                ProfilePictureLink = "https://better-default-discord.netlify.app/Icons/Gradient-Blue.png"
            },
        };
    }
}
