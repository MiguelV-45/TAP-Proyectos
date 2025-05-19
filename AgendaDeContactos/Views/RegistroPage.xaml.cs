using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;
using System.Diagnostics;

namespace AgendaDeContactos.Views
{
    public partial class RegistroPage : ContentPage
    {
        private readonly AppDatabase _database;

        public RegistroPage()
        {
            InitializeComponent();
            _database = new AppDatabase();
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text?.Trim();
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text;

            if (!ValidarCampos(username, email, password))
                return;

            try
            {
                if (await _database.ExisteUsuarioAsync(username))
                {
                    await DisplayAlert("Error", "El nombre de usuario ya existe", "OK");
                    return;
                }

                if (await _database.ExisteEmailAsync(email))
                {
                    await DisplayAlert("Error", "El correo electrónico ya está registrado", "OK");
                    return;
                }

                var nuevoUsuario = new Usuario
                {
                    NombreUsuario = username,
                    Email = email,
                    Password = password, // En producción usar hash
                    Activo = true,
                    EsAdmin = false
                };

                int resultado = await _database.GuardarUsuarioAsync(nuevoUsuario);

                if (resultado > 0)
                {
                    await DisplayAlert("Éxito", "Registro completado", "OK");

                    // Limpiar los campos
                    UsernameEntry.Text = string.Empty;
                    EmailEntry.Text = string.Empty;
                    PasswordEntry.Text = string.Empty;

                    // Regresar al login
                    await Shell.Current.GoToAsync("//login");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en registro: {ex.Message}");
                await DisplayAlert("Error", "No se pudo completar el registro", "OK");
            }
        }

        private bool ValidarCampos(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                DisplayAlert("Error", "Nombre de usuario requerido", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                DisplayAlert("Error", "Correo electrónico inválido", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                DisplayAlert("Error", "La contraseña debe tener al menos 6 caracteres", "OK");
                return false;
            }

            return true;
        }
    }
}