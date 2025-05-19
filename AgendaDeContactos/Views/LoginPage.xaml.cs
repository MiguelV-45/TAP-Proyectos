using AgendaDeContactos.Datos;
using System.Diagnostics;

namespace AgendaDeContactos.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly AppDatabase _database;

        public LoginPage()
        {
            InitializeComponent();
            _database = new AppDatabase();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.Quit();
            return true;
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = Username.Text?.Trim();
                string password = Password.Text;

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
                {
                    await DisplayAlert("Error", "Usuario y contraseña son requeridos", "OK");
                    return;
                }

                bool credencialesValidas = await _database.ValidarCredencialesAsync(usuario, password);

                if (credencialesValidas)
                {
                    Preferences.Set("UsuarioActual", usuario);
                    await SecureStorage.SetAsync("hasAuth", "true");
                    await Shell.Current.GoToAsync("///main");
                }
                else
                {
                    await DisplayAlert("Error", "Credenciales incorrectas", "OK");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en login: {ex.Message}");
                await DisplayAlert("Error", "Ocurrió un error al iniciar sesión", "OK");
            }
        }

        private async void TapGestureRecognizerReg_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("//registro");
        }

        private async void TapGestureRecognizerPwd_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("//recuperar");
        }
    }
}