using AgendaDeContactos.Modelos;
using System.Collections.Generic;

namespace AgendaDeContactos.Repositorio
{
    public static class ContactosRepositorio
    {
        public static List<Contacto> Contactos = new List<Contacto>();

        public static void AgregarContacto(Contacto contacto)
        {
            Contactos.Add(contacto);
        }

        public static List<Contacto> ObtenerContactos()
        {
            return Contactos;
        }
    }
}
