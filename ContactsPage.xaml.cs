namespace contactpro;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
    }

    private async void OnRetourAccueilClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}