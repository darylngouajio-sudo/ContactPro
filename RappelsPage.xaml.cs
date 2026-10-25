namespace contactpro;

public partial class RappelsPage : ContentPage
{
    public RappelsPage()
    {
        InitializeComponent();
        DateRappelPicker.Date = DateTime.Today;
    }

    private async void OnAjouterRappelClicked(
        object sender, EventArgs e)
    {
        string contact = ContactRappelEntry.Text?.Trim() ?? "";
        string objet = ObjetRappelEntry.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(contact) ||
            string.IsNullOrWhiteSpace(objet))
        {
            await DisplayAlertAsync(
                "Information",
                "Entre le nom du contact et l'objet de la relance.",
                "OK");
            return;
        }

        var carte = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#E1E7F0"),
            Padding = 14,
            StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new VerticalStackLayout
            {
                Spacing = 6,
                Children =
                {
                    new Label
                    {
                        Text = contact,
                        FontSize = 17,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#173B67")
                    },
                    new Label
                    {
                        Text = objet,
                        FontSize = 14,
                        TextColor = Color.FromArgb("#68778D")
                    },
                    new Label
                    {
                        Text = $"Date : {DateRappelPicker.Date:dd/MM/yyyy}",
                        FontSize = 14,
                        TextColor = Color.FromArgb("#246BFD")
                    }
                }
            }
        };

        ListeRappels.Children.Add(carte);
        ContactRappelEntry.Text = "";
        ObjetRappelEntry.Text = "";
    }

    private async void OnRetourAccueilClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}