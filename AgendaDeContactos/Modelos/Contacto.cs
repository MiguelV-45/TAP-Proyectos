using SQLite;

namespace AgendaDeContactos.Modelos
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; } = true;
    }

    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string NombreUsuario { get; set; }

        [Unique]
        public string Email { get; set; }

        public string Password { get; set; }
        public bool Activo { get; set; } = true;
        public bool EsAdmin { get; set; } = false;
    }
}
