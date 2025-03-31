using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class frmSQL : Form
    {
        private string Servidor;
        private string Basedatos;
        private string UsuarioId;
        private string Password;
        private string connectionString;

        public frmSQL(string servidor, string basedatos, string usuarioId, string password)
        {
            InitializeComponent();
            Servidor = servidor;
            Basedatos = basedatos;
            UsuarioId = usuarioId;
            Password = password;

            // Cadena de conexión SQL Server
            connectionString = $"Server={Servidor};Database={Basedatos};User Id={UsuarioId};Password={Password};";

            llenarGrid();
        }

        private void llenarGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Alumnos";
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);

                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgvAlumnos.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL Server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearBD_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strConn = $"Server={Servidor};User Id={UsuarioId};Password={Password}";

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    // Verificar si la BD ya existe
                    string checkDbQuery = @"
                IF EXISTS (SELECT * FROM sys.databases WHERE name = @DatabaseName)
                SELECT 1 ELSE SELECT 0";

                    SqlCommand checkCmd = new SqlCommand(checkDbQuery, conn);
                    checkCmd.Parameters.AddWithValue("@DatabaseName", Basedatos);
                    int dbExists = (int)checkCmd.ExecuteScalar();

                    if (dbExists == 1)
                    {
                        MessageBox.Show($"La base de datos '{Basedatos}' ya existe",
                                      "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Crear la BD si no existe
                        string createDbQuery = $"CREATE DATABASE {Basedatos}";
                        SqlCommand createCmd = new SqlCommand(createDbQuery, conn);
                        createCmd.ExecuteNonQuery();

                        MessageBox.Show($"Base de datos '{Basedatos}' creada exitosamente",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show($"Error SQL: {Ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreaTabla_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strConn = $"Server={Servidor};Database={Basedatos};User Id={UsuarioId};Password={Password}";

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    // Verificar si la tabla ya existe
                    string checkTableQuery = @"
                IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
                           WHERE TABLE_NAME = 'Alumnos')
                SELECT 1 ELSE SELECT 0";

                    SqlCommand checkCmd = new SqlCommand(checkTableQuery, conn);
                    int tableExists = (int)checkCmd.ExecuteScalar();

                    if (tableExists == 1)
                    {
                        MessageBox.Show("La tabla 'Alumnos' ya existe en la base de datos",
                                      "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Crear la tabla si no existe
                        string createTableQuery = @"
                    CREATE TABLE Alumnos (
                        NControl varchar(10) PRIMARY KEY,
                        nombre varchar(50),
                        carrera int
                    )";

                        SqlCommand createCmd = new SqlCommand(createTableQuery, conn);
                        createCmd.ExecuteNonQuery();

                        MessageBox.Show("Tabla 'Alumnos' creada exitosamente",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                llenarGrid();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show($"Error SQL: {Ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) return;

            string query = "INSERT INTO Alumnos (NControl, nombre, carrera) VALUES (@NControl, @Nombre, @Carrera)";
            var parametros = new[]
            {
                new SqlParameter("@NControl", NControl.Text),
                new SqlParameter("@Nombre", nombre.Text),
                new SqlParameter("@Carrera", carrera.Text)
            };

            if (EjecutarConsulta(query, parametros))
            {
                LimpiarCampos();
                llenarGrid();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NControl.Text))
            {
                MessageBox.Show("Ingrese un número de control");
                return;
            }

            string query = "DELETE FROM Alumnos WHERE NControl = @NControl";
            var parametro = new SqlParameter("@NControl", NControl.Text);

            if (EjecutarConsulta(query, parametro))
            {
                LimpiarCampos();
                llenarGrid();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NControl.Text))
            {
                MessageBox.Show("Ingrese un número de control");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Alumnos WHERE NControl = @NControl";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NControl", NControl.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre.Text = reader["nombre"].ToString();
                                carrera.Text = reader["carrera"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el alumno");
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) return;

            string query = "UPDATE Alumnos SET nombre = @Nombre, carrera = @Carrera WHERE NControl = @NControl";
            var parametros = new[]
            {
                new SqlParameter("@NControl", NControl.Text),
                new SqlParameter("@Nombre", nombre.Text),
                new SqlParameter("@Carrera", carrera.Text)
            };

            if (EjecutarConsulta(query, parametros))
            {
                llenarGrid();
            }
        }

        // Métodos auxiliares
        private bool EjecutarConsulta(string query, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parametros != null)
                        {
                            cmd.Parameters.AddRange(parametros);
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error en la consulta: {ex.Message}");
                return false;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(NControl.Text) ||
                string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(carrera.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return true;
            }

            if (!int.TryParse(carrera.Text, out _))
            {
                MessageBox.Show("Carrera debe ser un número");
                return true;
            }

            if (!int.TryParse(NControl.Text, out _))
            {
                MessageBox.Show("El numero de control debe ser un número");
                return true;
            }
            return false;
        }

        private void LimpiarCampos()
        {
            NControl.Clear();
            nombre.Clear();
            carrera.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
