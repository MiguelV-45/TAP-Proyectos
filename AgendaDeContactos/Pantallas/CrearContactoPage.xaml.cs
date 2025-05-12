using AgendaDeContactos.Modelos;
using AgendaDeContactos.Repositorio;

namespace AgendaDeContactos.Pantallas
{
    public partial class CrearContactoPage : ContentPage
    {
        public CrearContactoPage()
        {
            InitializeComponent();
        }

        // Método manejador del evento OnGuardarContactoClicked
        private async void OnGuardarContactoClicked(object sender, EventArgs e)
        {
            // Obtén los valores de los campos de entrada
            string nombre = NombreEntry.Text;
            string telefono = TelefonoEntry.Text;
            string correo = CorreoEntry.Text;
            string direccion = DireccionEntry.Text;

            // Crear un nuevo contacto
            var nuevoContacto = new Contacto
            {
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo,
                Direccion = direccion
            };

            // Agregar el nuevo contacto a la lista estática
            ContactosRepositorio.AgregarContacto(nuevoContacto);

            // Navegar a la página de contactos
            await Navigation.PopAsync();
        }
    }
}