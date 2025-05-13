using AgendaDeContactos.Utils;

namespace AgendaDeContactos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ConfiguracionApp.AplicarTemaGuardado();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}