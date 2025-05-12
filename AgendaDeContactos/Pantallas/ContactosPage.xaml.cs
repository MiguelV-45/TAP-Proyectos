using AgendaDeContactos.Modelos;
using AgendaDeContactos.Repositorio;
using System.Collections.ObjectModel;
using AgendaDeContactos.Pantallas;

namespace AgendaDeContactos.Pantallas
{
    public partial class ContactosPage : ContentPage
    {
        public ObservableCollection<Contacto> Contactos { get; set; }

        public ContactosPage()
        {
            InitializeComponent();
            Contactos = new ObservableCollection<Contacto>(ContactosRepositorio.ObtenerContactos());
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Sincroniza la colección Observable con los datos actuales del repositorio
            Contactos.Clear();
            foreach (var contacto in ContactosRepositorio.ObtenerContactos())
            {
                Contactos.Add(contacto);
            }
        }

        private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            var contactoSeleccionado = e.CurrentSelection.FirstOrDefault() as Contacto;
            if (contactoSeleccionado != null)
            {
                // Navegar a DetalleContactoPage y pasar el contacto seleccionado
                await Navigation.PushAsync(new DetalleContactoPage(contactoSeleccionado));
            }
        }
    }
}