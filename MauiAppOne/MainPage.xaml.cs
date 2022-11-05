using MauiAppOne.Models;

namespace MauiAppOne;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
