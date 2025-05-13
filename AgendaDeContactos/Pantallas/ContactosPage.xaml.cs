using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;
using System.Collections.ObjectModel;

namespace AgendaDeContactos.Pantallas
{
    public partial class ContactosPage : ContentPage
    {
        private ContactoDatabase db = new ContactoDatabase();
        public ObservableCollection<Contacto> Contactos { get; set; } = new();

        public ContactosPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Contactos.Clear();

            var lista = await db.ObtenerContactosAsync();
            foreach (var contacto in lista)
                Contactos.Add(contacto);
        }

        private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            var contactoSeleccionado = e.CurrentSelection.FirstOrDefault() as Contacto;
            if (contactoSeleccionado != null)
            {
                await Navigation.PushAsync(new DetalleContactoPage(contactoSeleccionado));
            }
        }
    }
}