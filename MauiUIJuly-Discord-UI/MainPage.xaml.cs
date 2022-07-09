using MauiUIJuly_Discord_UI.ViewModel;

namespace MauiUIJuly_Discord_UI;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

