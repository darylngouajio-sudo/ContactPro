namespace contactpro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAjouterContactClicked(
        object sender, EventArgs e)
    {
        string prenom = await DisplayPromptAsync(
            "Nouveau contact",
            "Entre le prénom :");

        if (prenom == null)
            return;

        string nom = await DisplayPromptAsync(
            "Nouveau contact",
            "Entre le nom :");

        if (nom == null)
            return;

        string telephone = await DisplayPromptAsync(
            "Nouveau contact",
            "Entre le numéro de téléphone :");

        if (telephone == null)
            return;

        string entreprise = await DisplayPromptAsync(
            "Nouveau contact",
            "Entre le nom de l'entreprise :");

        if (entreprise == null)
            return;

        var carte = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#E1E7F0"),
            StrokeShape =
                new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = 14
                },
            Padding = 16,
            Content = new VerticalStackLayout
            {
                Spacing = 6,
                Children =
                {
                    new Label
                    {
                        Text = $"{prenom} {nom}",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#173B67")
                    },
                    new Label
                    {
                        Text = telephone,
                        FontSize = 14,
                        TextColor = Color.FromArgb("#246BFD")
                    },
                    new Label
                    {
                        Text = entreprise,
                        FontSize = 14,
                        TextColor = Color.FromArgb("#68778D")
                    }
                }
            }
        };

        ListeContacts.Children.Add(carte);

        NombreContactsLabel.Text =
            ListeContacts.Children.Count.ToString();

        MessageVideLabel.IsVisible = false;
    }

    // Ouvrir la page Contacts
    private async void OnContactsCardTapped(
        object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ContactsPage));
    }

    // Ouvrir la page Groupes
    private async void OnGroupesCardTapped(
        object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GroupesPage));
    }

    // Ouvrir la page Notes
    private async void OnNotesCardTapped(
        object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NotesPage));
    }

    // Ouvrir la page Relances
    private async void OnRappelsCardTapped(
        object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RappelsPage));
    }
}