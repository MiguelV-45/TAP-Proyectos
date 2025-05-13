using AgendaDeContactos.Utils;
namespace AgendaDeContactos;

public partial class ConfiguracionPage : ContentPage
{
	public ConfiguracionPage()
	{
		InitializeComponent();
	}
    private async void LogoutButton_Clicked(object sender, EventArgs e)
    {
        if (await DisplayAlert("Seguro que quieres cerrar sesion?", "Sesion.", "Yes", "No"))
        {
            Preferences.Remove("UsuarioActual");
            SecureStorage.RemoveAll();
            await Shell.Current.GoToAsync("///login");
        }
    }
    private void OnCambiarTemaClicked(object sender, EventArgs e)
    {
        bool temaOscuro = App.Current.UserAppTheme == AppTheme.Dark;

        // Cambiar y guardar el nuevo tema
        bool nuevoTemaOscuro = !temaOscuro;
        ConfiguracionApp.GuardarTema(nuevoTemaOscuro);
        App.Current.UserAppTheme = nuevoTemaOscuro ? AppTheme.Dark : AppTheme.Light;
    }
}