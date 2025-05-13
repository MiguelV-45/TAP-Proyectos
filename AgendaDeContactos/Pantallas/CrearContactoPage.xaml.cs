using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos.Pantallas
{
    public partial class CrearContactoPage : ContentPage
    {
        private ContactoDatabase db = new ContactoDatabase();

        public CrearContactoPage()
        {
            InitializeComponent();
        }

        private async void OnGuardarContactoClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string telefono = TelefonoEntry.Text;
            string correo = CorreoEntry.Text;
            string direccion = DireccionEntry.Text;

            var nuevoContacto = new Contacto
            {
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo,
                Direccion = direccion
            };

            await db.GuardarContactoAsync(nuevoContacto);
            await Navigation.PopAsync();
        }
    }
}