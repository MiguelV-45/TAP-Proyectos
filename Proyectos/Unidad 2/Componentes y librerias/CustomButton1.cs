using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2ComponentesLibrerias
{

    /// <summary>
    /// Control de usuario personalizado que extiende un botón con funcionalidad adicional.
    /// </summary>
    public partial class CustomButton1: UserControl
    {
        private Color originalBackColor;
        private Color hoverBackColor = Color.Red; // Color al pasar el cursor

        /// <summary>
        /// Evento que se dispara cuando el usuario confirma un doble clic en el botón.
        /// </summary>
        public event EventHandler DoubleClickConfirmed;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CustomButton1"/>.
        /// </summary>
        public CustomButton1()
        {
            InitializeComponent();

            // Guardamos el color original del botón
            originalBackColor = button1.BackColor;

            // Asignar los eventos al botón dentro del UserControl
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button1.MouseDown += Button1_MouseDown; // Detectar doble clic
        }

        /// <summary>
        /// Obtiene o establece el color del botón cuando el cursor pasa sobre él.
        /// </summary>
        public Color HoverBackColor
        {
            get { return hoverBackColor; }
            set { hoverBackColor = value; }
        }

        /// <summary>
        /// Maneja el evento cuando el cursor entra en el botón.
        /// </summary>
        /// <param name="sender">El objeto que dispara el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = hoverBackColor;
        }

        /// <summary>
        /// Maneja el evento cuando el cursor sale del botón.
        /// </summary>
        /// <param name="sender">El objeto que dispara el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = originalBackColor;
        }

        /// <summary>
        /// Maneja el evento de doble clic en el botón y muestra una confirmación.
        /// </summary>
        /// <param name="sender">El objeto que dispara el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificamos si el número de clics es 2 (doble clic)
            if (e.Clicks == 2)
            {
                // Mostrar cuadro de confirmación
                var result = MessageBox.Show("¿Está seguro de continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Si el usuario confirma, lanzamos el evento
                    DoubleClickConfirmed?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}