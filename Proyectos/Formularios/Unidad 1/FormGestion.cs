using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class FormGestion : Form
    {
        public FormGestion()
        {
            InitializeComponent();
             // Asignar el evento KeyPress al txtTelefono..
            txtTelefono.KeyPress += TxtTelefono_KeyPress;
        }

        //----------------------- Eventos del menuStrip ----------------------//
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Salir del programa
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un MessageBox con información del programa
            MessageBox.Show("GestionContactos 1.0\n\nEs un programa simple para gestionar contactos el cual se puede agregar el nombre, telefono y correo del contacto, al igual que se pueden eliminar los contactos no deseados .", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //----------------------- Eventos de los botones ----------------------//
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una cadena con los datos del contacto
            string contacto = $"|--Nombre: {txtNombre.Text}--|   |--Telefono: {txtTelefono.Text}--|   |--Correo: {txtCorreo.Text}--|";

            // Agregar el contacto a la lista
            lstListaContactos.Items.Add(contacto);

            // Mostrar mensaje de confirmación
            MessageBox.Show("Contacto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que haya un elemento seleccionado
            if (lstListaContactos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un contacto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eliminar el contacto seleccionado
            lstListaContactos.Items.RemoveAt(lstListaContactos.SelectedIndex);

            // Mostrar mensaje de confirmación
            MessageBox.Show("Contacto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //----------------------- Evento KeyPress para txtTelefono ----------------------//
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Este campo solo acepta numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true; // Ignorar la tecla presionada
            }
        }
    }
}