namespace AgendaDeContactos.Views;

public partial class RecuperarPage : ContentPage
{
    public RecuperarPage()
    {
        InitializeComponent();
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string newPassword = NewPasswordEntry.Text;

        // Aquí podrías agregar validaciones o guardar en almacenamiento seguro

        await DisplayAlert("Contraseña actualizada", $"Tu contraseña ha sido actualizada para {email}", "OK");
        await Navigation.PopAsync();
    }


}