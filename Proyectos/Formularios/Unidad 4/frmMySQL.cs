using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyectos
{
    public partial class frmMySQL : Form
    {
        private string Servidor;
        private string Basedatos;
        private string UsuarioId;
        private string Password;

        public frmMySQL(string servidor, string basedatos, string usuarioId, string password)
        {
            InitializeComponent();
            Servidor = servidor;
            Basedatos = basedatos;
            UsuarioId = usuarioId;
            Password = password;

            llenarGrid();
        }

        private void EjecutaComando(string ConsultaSQL)
        {
            try
            {
                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(ConsultaSQL, conn);
                    cmd.ExecuteNonQuery();
                }

                llenarGrid();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void llenarGrid()
        {
            try
            {
                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Alumnos";
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);

                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos");
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = $"Server={Servidor};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS ESCOLAR", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Base de datos creada correctamente");
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE IF NOT EXISTS Alumnos (NControl varchar(10) PRIMARY KEY, nombre varchar(50), carrera int)");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NControl.Text.Trim().Length == 0 ||
                    nombre.Text.Trim().Length == 0 ||
                    carrera.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Faltan datos");
                    return;
                }

                if (!int.TryParse(carrera.Text.Trim(), out int carreraValue))
                {
                    MessageBox.Show("Carrera debe ser un número");
                    return;
                }

                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                    // Verificar si ya existe
                    string checkQuery = "SELECT COUNT(*) FROM Alumnos WHERE NControl = @NControl";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NControl", NControl.Text);
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Ya existe un alumno con este número de control");
                            return;
                        }
                    }

                    // Insertar
                    string insertQuery = "INSERT INTO Alumnos (NControl, nombre, carrera) VALUES (@NControl, @Nombre, @Carrera)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NControl", NControl.Text);
                        cmd.Parameters.AddWithValue("@Nombre", nombre.Text);
                        cmd.Parameters.AddWithValue("@Carrera", carreraValue);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alumno insertado correctamente");
                    }
                }

                llenarGrid();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NControl.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese un número de control");
                    return;
                }

                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sqlQuery = "DELETE FROM Alumnos WHERE NControl = @NControl";
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NControl", NControl.Text);
                        int filas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filas > 0 ? "Alumno eliminado" : "No se encontró el alumno");
                    }
                }

                llenarGrid();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NControl.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese un número de control");
                    return;
                }

                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Alumnos WHERE NControl = @NControl";
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NControl", NControl.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NControl.Text = reader["NControl"].ToString();
                                nombre.Text = reader["nombre"].ToString();
                                carrera.Text = reader["carrera"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el alumno");
                            }
                        }
                    }
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NControl.Text.Trim().Length == 0 ||
                    nombre.Text.Trim().Length == 0 ||
                    carrera.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Faltan datos");
                    return;
                }

                if (!int.TryParse(carrera.Text.Trim(), out int carreraValue))
                {
                    MessageBox.Show("Carrera debe ser un número");
                    return;
                }

                string strConn = $"Server={Servidor};Database={Basedatos};Uid={UsuarioId};Pwd={Password};";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sqlQuery = "UPDATE Alumnos SET nombre = @Nombre, carrera = @Carrera WHERE NControl = @NControl";
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NControl", NControl.Text);
                        cmd.Parameters.AddWithValue("@Nombre", nombre.Text);
                        cmd.Parameters.AddWithValue("@Carrera", carreraValue);
                        int filas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filas > 0 ? "Alumno actualizado" : "No se encontró el alumno");
                    }
                }

                llenarGrid();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
    }
}