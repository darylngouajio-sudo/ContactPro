namespace contactpro
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(ContactsPage),
                typeof(ContactsPage));

            Routing.RegisterRoute(
                nameof(GroupesPage),
                typeof(GroupesPage));

            Routing.RegisterRoute(
                nameof(NotesPage),
                typeof(NotesPage));

            Routing.RegisterRoute(
                nameof(RappelsPage),
                typeof(RappelsPage));
        }
    }
}