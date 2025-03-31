using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyectos
{ 
    public partial class FormGUI_Dinamico : Form
    {
        // Declaración de controles.
        private Button btnSeleccionarCarpeta; // Boton para seleccionar la carpeta de las imagenes.
        private Button btnCargarImagen; // Boton para cargar una imagen.
        private Button btnLimpiarImagenes; // Boton para limpiar todas las imagenes.
        private Button btnCerrarPrograma; // Boton para cerrar el programa.
        private Panel panelBotones; // Panel para los botones.
        private ContextMenuStrip menuContextual; // Menu contextual para las imagenes.
        private Label lblInstrucciones; // Label con las instrucciones de como borrar una imagen,

        // Instancia de la clase MetodosImagenes.
        private MetodosImagenes metodosImagenes;

        public FormGUI_Dinamico()
        {
            InitializeComponent(); // Inicializar los componentes del formulario
            metodosImagenes = new MetodosImagenes(); // Inicializar la clase auxiliar.
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            this.Text = "Cargar Imágenes Dinámicamente"; // Titulo del formulario.
            this.Size = new Size(800, 600); // Tamano del formulario


            //-------------------------- Botones, Panel y Label --------------------------//

            // Crear el panel para los botones.
            panelBotones = new Panel(); // Creacion del panel.
            panelBotones.Location = new Point(0, 0); // Posicion del plantel.
            panelBotones.Size = new Size(this.ClientSize.Width, 60); // tamano del panel.
            panelBotones.BackColor = Color.LightGray; // Color de fondo del panel.
            this.Controls.Add(panelBotones); // Agregar el panel al formulario.

            // Bton para seleccionar la carpeta de las imagenes
            btnSeleccionarCarpeta = new Button(); // Creacion del boton.
            btnSeleccionarCarpeta.Text = "Seleccionar Carpeta"; // Texto del boton.
            btnSeleccionarCarpeta.Location = new Point(20, 10); // Posicion del boton.
            btnSeleccionarCarpeta.Click += new EventHandler(SeleccionarCarpeta); // Evento del boton.
            panelBotones.Controls.Add(btnSeleccionarCarpeta); // Agregar el boton al panel.

            // Boton para cargar una imagen.
            btnCargarImagen = new Button(); // Creacion del boton.
            btnCargarImagen.Text = "Cargar Imagen"; // Texto del boton.
            btnCargarImagen.Location = new Point(150, 10); // Posicion del boton.
            btnCargarImagen.Click += new EventHandler(CargarImagen); // Evento del boton.
            panelBotones.Controls.Add(btnCargarImagen); // Agregar el boton al panel.

            // Boton para limpiar todas las imagenes.
            btnLimpiarImagenes = new Button(); // Creacion del boton.
            btnLimpiarImagenes.Text = "Limpiar Imágenes"; // Texto del boton.
            btnLimpiarImagenes.Location = new Point(280, 10); // Posicion del boton.
            btnLimpiarImagenes.Click += new EventHandler(LimpiarImagenes); // Evento del boton.
            panelBotones.Controls.Add(btnLimpiarImagenes); // Agregar el boton al panel.

            // Boton para cerrar el programa.
            btnCerrarPrograma = new Button(); // Creacion del boton.
            btnCerrarPrograma.Text = "Cerrar Programa"; // Texto del boton.
            btnCerrarPrograma.Location = new Point(410, 10); // Posicion del boton.
            btnCerrarPrograma.Click += new EventHandler(CerrarPrograma); // Evento del boton.
            panelBotones.Controls.Add(btnCerrarPrograma); // Agregar el boton al panel.

            // Crear el menú contextual.
            menuContextual = new ContextMenuStrip(); // Creacion del menu contextual.
            ToolStripMenuItem eliminarImagenItem = new ToolStripMenuItem("Eliminar Imagen"); // Creacion del item del menu.
            eliminarImagenItem.Click += (s, ev) => metodosImagenes.EliminarImagen(s, ev, this.Controls); // Evento del item.
            menuContextual.Items.Add(eliminarImagenItem); // Agregar el item al menu.

            // Crear el Label con las instrucciones.
            lblInstrucciones = new Label(); // Creacion del label.
            lblInstrucciones.Text = "*Haz clic derecho en una imagen para eliminarla."; // Texto del label.
            lblInstrucciones.AutoSize = true; // Ajustar el tamano del label.
            lblInstrucciones.Location = new Point(20, 37); // Posicion del panel.
            lblInstrucciones.ForeColor = Color.DarkGray; // Color del texto.
            lblInstrucciones.Font = new Font("Arial", 9); // Fuente del contexto.
            panelBotones.Controls.Add(lblInstrucciones); // Agregar el label al panel.
        }

        // Método para seleccionar la carpeta de las imágenes.
        private void SeleccionarCarpeta(object sender, EventArgs e)
        {
            metodosImagenes.SeleccionarCarpeta(); // Llamar al metodo de la clase MetodosImagenes.
        }

        // Método para cargar una imagen.
        private void CargarImagen(object sender, EventArgs e)
        {
            PictureBox nuevaImagen = metodosImagenes.CargarImagen(metodosImagenes.VerImagenCompleta, menuContextual); // Llamar al metodo de la clase MetodosImagenes.
            if (nuevaImagen != null) //Si la imagen no es nula, agregarla al formulario
            {
                nuevaImagen.Location = new Point(20 + (metodosImagenes.ContadorImagenes % 5) * 120, panelBotones.Height + 20 + (metodosImagenes.ContadorImagenes / 5) * 120); // Posicion de la imagen.
                this.Controls.Add(nuevaImagen); // Agregar la imagen al formulario.
            }
        }

        // Método para limpiar todas las imágenes.
        private void LimpiarImagenes(object sender, EventArgs e)
        {
            metodosImagenes.LimpiarImagenes(this.Controls); // Llamar al metodo de la clase MetodosImagenes.
        }

        // Método para cerrar el programa.
        private void CerrarPrograma(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}
