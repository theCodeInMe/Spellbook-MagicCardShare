namespace MagicCardShare
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainMenu), typeof(MainMenu));
            Routing.RegisterRoute(nameof(CardEditor), typeof(CardEditor));

        }
    }
}
