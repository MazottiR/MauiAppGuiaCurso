using Microsoft.Maui.Controls;
using MauiAppGuiaCurso;

namespace MeuAppMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnPage1Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1());
    }

    private async void OnPage2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2());
    }

    private async void OnPage3Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

    private async void OnPage4Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }
}