using SQLite;
using AgendaDeContactos.Modelos;
using System.Diagnostics;

namespace AgendaDeContactos.Datos
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDatabase()
        {
            _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "agenda.db3"));
            InitializeDatabaseAsync().SafeFireAndForget();
        }

        private async Task InitializeDatabaseAsync()
        {
            try
            {
                await _database.CreateTableAsync<Contacto>();
                await _database.CreateTableAsync<Usuario>();
                await CrearUsuarioAdminPorDefecto();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error inicializando DB: {ex.Message}");
            }
        }

        private async Task CrearUsuarioAdminPorDefecto()
        {
            var adminExistente = await _database.Table<Usuario>()
                .Where(u => u.NombreUsuario == "miguel")
                .FirstOrDefaultAsync();

            if (adminExistente == null)
            {
                await _database.InsertAsync(new Usuario
                {
                    NombreUsuario = "miguel",
                    Email = "admin@admin.com",
                    Password = "2005",
                    EsAdmin = true,
                    Activo = true
                });
            }
        }

        #region Operaciones Contactos
        public async Task<List<Contacto>> ObtenerContactosAsync() =>
            await _database.Table<Contacto>().Where(c => c.Activo).ToListAsync();

        public async Task<Contacto> ObtenerContactoPorIdAsync(int id) =>
            await _database.Table<Contacto>().Where(c => c.Id == id).FirstOrDefaultAsync();

        public async Task<int> GuardarContactoAsync(Contacto contacto) =>
            contacto.Id == 0 ? await _database.InsertAsync(contacto) : await _database.UpdateAsync(contacto);

        public async Task<int> EliminarContactoAsync(Contacto contacto)
        {
            contacto.Activo = false;
            return await _database.UpdateAsync(contacto);
        }
        #endregion

        #region Operaciones Usuarios
        public async Task<Usuario> ObtenerUsuarioAsync(string nombreUsuario) =>
            await _database.Table<Usuario>()
                .Where(u => u.NombreUsuario == nombreUsuario && u.Activo)
                .FirstOrDefaultAsync();

        public async Task<int> GuardarUsuarioAsync(Usuario usuario) =>
            usuario.Id == 0 ? await _database.InsertAsync(usuario) : await _database.UpdateAsync(usuario);

        public async Task<bool> ValidarCredencialesAsync(string nombreUsuario, string password)
        {
            if (nombreUsuario == "miguel" && password == "2005")
                return true;

            var usuario = await ObtenerUsuarioAsync(nombreUsuario);
            return usuario != null && usuario.Password == password;
        }

        public async Task<bool> ExisteUsuarioAsync(string nombreUsuario) =>
            await _database.Table<Usuario>()
                .Where(u => u.NombreUsuario == nombreUsuario)
                .CountAsync() > 0;

        public async Task<bool> ExisteEmailAsync(string email) =>
            await _database.Table<Usuario>()
                .Where(u => u.Email == email)
                .CountAsync() > 0;
        #endregion
    }

    public static class TaskExtensions
    {
        public static void SafeFireAndForget(this Task task, Action<Exception> onException = null)
        {
            task.ContinueWith(t => {
                if (t.IsFaulted && onException != null)
                    onException(t.Exception);
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}