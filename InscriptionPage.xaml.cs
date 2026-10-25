namespace contactpro;

public partial class InscriptionPage : ContentPage
{
    public InscriptionPage()
    {
        InitializeComponent();
    }

    private async void OnInscriptionClicked(
        object sender, EventArgs e)
    {
        string nom = NomInscriptionEntry.Text?.Trim() ?? "";
        string email = EmailInscriptionEntry.Text?.Trim() ?? "";
        string motDePasse = MotDePasseEntry.Text ?? "";

        if (string.IsNullOrWhiteSpace(nom) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(motDePasse))
        {
            await DisplayAlertAsync(
                "Champs manquants",
                "Remplis tous les champs.",
                "OK");
            return;
        }

        if (!email.Contains('@') || !email.Contains('.'))
        {
            await DisplayAlertAsync(
                "E-mail invalide",
                "Entre une adresse e-mail valide.",
                "OK");
            return;
        }

        if (motDePasse.Length < 6)
        {
            await DisplayAlertAsync(
                "Mot de passe",
                "Le mot de passe doit contenir au moins 6 caractères.",
                "OK");
            return;
        }

        MessageInscriptionLabel.Text =
            $"Formulaire validé pour {nom}.";

        await DisplayAlertAsync(
            "Inscription",
            "Le formulaire est valide. La création réelle du compte nécessite encore un système d'authentification.",
            "OK");
    }

    private async void OnRetourAccueilClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
