namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registra as rotas para navegação
            Routing.RegisterRoute(nameof(ConfirmacaoPage), typeof(ConfirmacaoPage));
            Routing.RegisterRoute(nameof(SobrePage), typeof(SobrePage));
        }
    }
}
