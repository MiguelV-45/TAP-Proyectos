using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AgendaDeContactos.Pantallas
{
    public partial class ContactosPage : ContentPage
    {
        private readonly AppDatabase _database;
        public ObservableCollection<Contacto> Contactos { get; } = new();

        public ContactosPage()
        {
            InitializeComponent();
            _database = new AppDatabase();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await CargarContactos();
        }

        private async Task CargarContactos()
        {
            try
            {
                Contactos.Clear();
                var lista = await _database.ObtenerContactosAsync();

                foreach (var contacto in lista)
                    Contactos.Add(contacto);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error cargando contactos: {ex.Message}");
                await DisplayAlert("Error", "Error cargando contactos", "OK");
            }
        }

        private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contacto contacto)
            {
                await Navigation.PushAsync(new DetalleContactoPage(contacto));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}