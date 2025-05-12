namespace AgendaDeContactos.Views;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        // Obtener los valores de los campos
        string username = UsernameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        // Validar los campos
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Todos los campos son requeridos.", "OK");
        }
        else
        {
            // Aquí agregarías la lógica para almacenar el usuario en una base de datos o cualquier otra acción
            await DisplayAlert("Éxito", "Usuario registrado exitosamente.", "OK");
            await Shell.Current.GoToAsync("//login"); // Regresar a la página de login
        }
    }
}