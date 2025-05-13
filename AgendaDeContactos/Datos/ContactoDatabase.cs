
using SQLite;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos.Datos
{
    public class ContactoDatabase
    {
        private readonly SQLiteAsyncConnection _db;

        public ContactoDatabase()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "agenda.db");
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Contacto>().Wait();
        }

        public Task<List<Contacto>> ObtenerContactosAsync() =>
            _db.Table<Contacto>().Where(c => c.Activo).ToListAsync();

        public Task<Contacto> ObtenerContactoPorIdAsync(int id) =>
            _db.Table<Contacto>().Where(c => c.Id == id).FirstOrDefaultAsync();

        public Task<int> GuardarContactoAsync(Contacto contacto) =>
            contacto.Id != 0 ? _db.UpdateAsync(contacto) : _db.InsertAsync(contacto);

        public Task<int> EliminarContactoAsync(Contacto contacto)
        {
            contacto.Activo = false;
            return _db.UpdateAsync(contacto);
        }
    }
}