using AgendaDeContactos.Modelos;
using AgendaDeContactos.Repositorio;

namespace AgendaDeContactos.Pantallas
{
    public partial class DetalleContactoPage : ContentPage
    {
        private Contacto contactoOriginal;

        // Constructor que recibe un contacto
        public DetalleContactoPage(Contacto contacto)
        {
            InitializeComponent();
            contactoOriginal = contacto;  // Asignamos el contacto a la variable de instancia
            BindingContext = contactoOriginal;  // Vinculamos el contacto al BindingContext
        }

        // Método para eliminar el contacto
        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            bool confirmado = await DisplayAlert("Confirmar", "¿Eliminar este contacto?", "Sí", "No");
            if (confirmado)
            {
                // Eliminamos el contacto de la lista
                ContactosRepositorio.Contactos.Remove(contactoOriginal);
                await Navigation.PopAsync(); // Regresamos a la lista de contactos
            }
        }

        // Método para guardar los cambios del contacto
        private async void OnGuardarCambiosClicked(object sender, EventArgs e)
        {
            // Actualizamos los valores del contacto original con los valores de los Entry
            contactoOriginal.Nombre = NombreEntry.Text;
            contactoOriginal.Telefono = TelefonoEntry.Text;
            contactoOriginal.Correo = CorreoEntry.Text;
            contactoOriginal.Direccion = DireccionEntry.Text;

            // Volvemos a la página de contactos
            await Navigation.PopAsync();
        }
    }
}