namespace contactpro;

public partial class GroupesPage : ContentPage
{
    public GroupesPage()
    {
        InitializeComponent();
    }

    private async void OnRetourAccueilClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}