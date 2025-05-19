using AgendaDeContactos.Views;

namespace AgendaDeContactos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rutas
            Routing.RegisterRoute("//login", typeof(LoginPage));
            Routing.RegisterRoute("//registro", typeof(RegistroPage));
        }
    }
}
