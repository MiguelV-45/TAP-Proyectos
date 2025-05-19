using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;
using System.Diagnostics;

namespace AgendaDeContactos.Pantallas
{
    public partial class DetalleContactoPage : ContentPage
    {
        private AppDatabase db = new AppDatabase();
        private Contacto contactoOriginal;

        public DetalleContactoPage(Contacto contacto)
        {
            InitializeComponent();
            contactoOriginal = contacto;
            BindingContext = contactoOriginal;
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            bool confirmado = await DisplayAlert("Confirmar", "¿Eliminar este contacto?", "Sí", "No");
            if (confirmado)
            {
                await db.EliminarContactoAsync(contactoOriginal);
                await Navigation.PopAsync();
            }
        }

        private async void OnGuardarCambiosClicked(object sender, EventArgs e)
        {
            contactoOriginal.Nombre = NombreEntry.Text;
            contactoOriginal.Telefono = TelefonoEntry.Text;
            contactoOriginal.Correo = CorreoEntry.Text;
            contactoOriginal.Direccion = DireccionEntry.Text;

            await db.GuardarContactoAsync(contactoOriginal);
            await Navigation.PopAsync();
        }
    }
}