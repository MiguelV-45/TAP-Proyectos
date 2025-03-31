using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyectos
{
    public partial class frmCredenciales : Form
    {
        public string dbType;

        public frmCredenciales(string databaseType)
        {
            InitializeComponent();
            dbType = databaseType;
            this.Text = $"Conectar a {dbType}";

            // Configurar el campo de contraseña
            txtPassword.PasswordChar = '*';
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string basedatos = txtBasedatos.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(servidor) ||
                string.IsNullOrWhiteSpace(basedatos) ||
                string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Complete todos los campos requeridos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (dbType == "SQL")
                {
                    string connectionString = $"Server={servidor};Database={basedatos};User Id={usuario};Password={password};";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        conn.Close();
                    }

                    this.Hide();
                    frmSQL sqlForm = new frmSQL(servidor, basedatos, usuario, password);
                    sqlForm.ShowDialog();
                }
                else if (dbType == "MySQL")
                {
                    string connectionString = $"Server={servidor};Database={basedatos};Uid={usuario};Pwd={password};";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        conn.Close();
                    }

                    this.Hide();
                    frmMySQL mysqlForm = new frmMySQL(servidor, basedatos, usuario, password);
                    mysqlForm.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}