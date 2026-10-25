namespace contactpro;

public partial class NotesPage : ContentPage
{
    public NotesPage()
    {
        InitializeComponent();
    }

    private async void OnEnregistrerNoteClicked(
        object sender, EventArgs e)
    {
        string titre = TitreNoteEntry.Text?.Trim() ?? "";
        string contenu = ContenuNoteEditor.Text?.Trim() ?? "";

        if (titre.Length == 0 || contenu.Length == 0)
        {
            await DisplayAlertAsync(
                "Champs manquants",
                "Entre le titre et le contenu de la note.",
                "OK");
            return;
        }

        Label note = new Label
        {
            Text = titre + "\n" + contenu,
            FontSize = 16,
            TextColor = Colors.DarkBlue,
            BackgroundColor = Colors.White,
            Padding = 12
        };

        ListeNotes.Children.Add(note);

        TitreNoteEntry.Text = string.Empty;
        ContenuNoteEditor.Text = string.Empty;
    }

    private async void OnRetourAccueilClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}