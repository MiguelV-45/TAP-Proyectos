using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTexBox
{
    /// <summary>
    /// Control de usuario personalizado para la entrada de texto con restricciones de tipo de entrada.
    /// </summary>
    public partial class CustomTexBox1 : UserControl
    {
        /// <summary>
        /// Inicializa una nueva instancia del control <see cref="CustomTexBox1"/>.
        /// </summary>
        public CustomTexBox1()
        {
            InitializeComponent();
            // Asignar los eventos a los botones
            btnNumeros.Click += buttonNumeros_Click;
            btnLetras.Click += buttonLetras_Click;
            btnAlfanumerico.Click += buttonAlfanumerico_Click;
        }

        /// <summary>
        /// Enumeración para definir el tipo de entrada permitido.
        /// </summary>
        public enum TipoEntrada
        {
            /// <summary>
            /// Solo se permiten números.
            /// </summary>
            Numeros,

            /// <summary>
            /// Solo se permiten letras.
            /// </summary>
            Letras,

            /// <summary>
            /// Se permiten números y letras.
            /// </summary>
            Alfanumerico
        }

        private TipoEntrada _tipoEntrada = TipoEntrada.Numeros;

        /// <summary>
        /// Obtiene o establece el tipo de entrada permitida.
        /// </summary>
        public TipoEntrada EntradaPermitida
        {
            get { return _tipoEntrada; }
            set { _tipoEntrada = value; }
        }

        /// <summary>
        /// Maneja el evento KeyPress para validar la entrada de texto según el tipo permitido.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los datos del evento KeyPress.</param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = false;

            switch (_tipoEntrada)
            {
                case TipoEntrada.Numeros:
                    esValido = Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
                    break;

                case TipoEntrada.Letras:
                    esValido = Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back;
                    break;

                case TipoEntrada.Alfanumerico:
                    esValido = Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
                    break;
            }

            // Si no es válido, cambiar el color de fondo a rojo
            if (!esValido)
            {
                textBox1.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
            }

            // Cancelar la entrada si no es válida
            e.Handled = !esValido;
        }

        /// <summary>
        /// Cambia el modo de entrada a solo números.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonNumeros_Click(object sender, EventArgs e)
        {
            _tipoEntrada = TipoEntrada.Numeros;
            textBox1.Clear();
            MessageBox.Show("Modo cambiado a Números", "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cambia el modo de entrada a solo letras.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonLetras_Click(object sender, EventArgs e)
        {
            _tipoEntrada = TipoEntrada.Letras;
            textBox1.Clear();
            MessageBox.Show("Modo cambiado a Letras", "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cambia el modo de entrada a alfanumérico.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonAlfanumerico_Click(object sender, EventArgs e)
        {
            _tipoEntrada = TipoEntrada.Alfanumerico;
            textBox1.Clear();
            MessageBox.Show("Modo cambiado a Alfanumérico", "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}