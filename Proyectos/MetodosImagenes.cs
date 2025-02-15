using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public class MetodosImagenes
    {
        private List<PictureBox> listaPictureBoxes = new List<PictureBox>();  // Lista para almacenar los PictureBox..
        public int ContadorImagenes { get; private set; } = 0;  // Contador para llevar la cuenta de las imágenes cargadas.
        private string[] archivosImagenes; // Arreglo para almacenar las rutas de las imágenes.
        private int indiceImagenActual = 0; // Índice para llevar la cuenta de la imagen actual.

        // Método para seleccionar una carpeta y cargar las rutas de las imágenes.
        public string[] SeleccionarCarpeta()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog()) // Crear un cuadro de dialogo para seleccionar una carpeta.
            {
                if (folderDialog.ShowDialog() == DialogResult.OK) // Si el usuario selecciona una carpeta
                {
                    string rutaCarpetaSeleccionada = folderDialog.SelectedPath; // Obtener la ruta de la carpeta seleccionada.
                    MessageBox.Show("Carpeta seleccionada: " + rutaCarpetaSeleccionada); // Mostrar la ruta de la carpeta seleccionada.

                    // Obtener las rutas de las imágenes en la carpeta seleccionada.
                    archivosImagenes = Directory.GetFiles(rutaCarpetaSeleccionada, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(file => file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png")) // Filtrar solo las imagenes jpg y png.
                                            .ToArray(); // Convertir a un arreglo.

                    if (archivosImagenes.Length == 0) // Si no se encuentran imagenes en la carpeta.
                    {
                        MessageBox.Show("No se encontraron imágenes en la carpeta seleccionada."); // Mostrar mensajes.
                    }
                    else
                    {
                        MessageBox.Show($"Se encontraron {archivosImagenes.Length} imágenes en la carpeta."); // Mostrar mensaje.
                        indiceImagenActual = 0; // Reiniciar el índice de la imagen actual.
                        ContadorImagenes = 0; // Reiniciar el contador de imágenes.
                    }
                }
            }
            return archivosImagenes;
        }

        // Método para cargar una imagen en un PictureBox.
        public PictureBox CargarImagen(EventHandler verImagenCompleta, ContextMenuStrip menuContextual)
        {
            if (archivosImagenes == null || archivosImagenes.Length == 0) // Si no se han seleccionado imagenes.
            {
                MessageBox.Show("No hay imágenes para cargar. Selecciona una carpeta primero."); // Mostrar mensaje.
                return null; // Retornar nulo.
            }

            if (indiceImagenActual < archivosImagenes.Length) //Si hay mas imagenes por cargar.
            {
                PictureBox nuevoPictureBox = new PictureBox(); // Se crea un nuevo PictureBox.
                nuevoPictureBox.Image = Image.FromFile(archivosImagenes[indiceImagenActual]); // Cargar la imagen en el PictureBox.
                nuevoPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen al PictureBox.
                nuevoPictureBox.Size = new Size(100, 100); // Tamano del PicturBox.
                nuevoPictureBox.Click += verImagenCompleta; // Asignar evento para ver la imagen completa.
                nuevoPictureBox.ContextMenuStrip = menuContextual; // Asignar menú contextual.

                listaPictureBoxes.Add(nuevoPictureBox); // Agregar el PictureBox a la lista.
                indiceImagenActual++; // Incrementar el índice de la imagen actual.
                nuevoPictureBox.Tag = archivosImagenes[indiceImagenActual - 1]; // Guardar la ruta de la imagen en el Tag.
                ContadorImagenes++; // Incrementar el contador de imágenes.

                return nuevoPictureBox; // Retorna el PictureBox creado.
            }
            else // Si ya se han cargado todas las imagenes.
            {
                MessageBox.Show("Todas las imágenes han sido cargadas."); // Mostrar mensaje.
                return null; // Retornar nulo.
            }
        }

        // Método para limpiar todas las imágenes.
        public void LimpiarImagenes(Control.ControlCollection controles)
        {
            foreach (var pictureBox in listaPictureBoxes) // Recorre la lista de PictureBox.
            {
                controles.Remove(pictureBox); // Eliminar el PictureBox del formulario.
                pictureBox.Dispose(); // Liberar recursos del PictureBox.
            }
            listaPictureBoxes.Clear(); // Limpiar la lista de PictureBox.
            indiceImagenActual = 0; // Reiniciar el índice de la imagen actual.
            ContadorImagenes = 0; // Reiniciar el contador de imágenes.

            MessageBox.Show("Todas las imágenes han sido limpiadas."); // Mostrar mensaje.
        }

        // Método para ver una imagen en tamaño completo.
        public void VerImagenCompleta(object sender, EventArgs e)
        {
            PictureBox pictureBoxClickeado = sender as PictureBox; // Obtener el PictureBox clickeado.
            string rutaImagen = pictureBoxClickeado.Tag.ToString(); // Obtener la ruta de la imagen.
            string nombreImagen = Path.GetFileName(rutaImagen); // Obtener el nombre de la imagen.

            Form ventanaImagen = new Form(); // Crear una ventan para mostrar la imagen.
            ventanaImagen.Text = nombreImagen; // Asignar el nombre de la imagen a la ventana.
            ventanaImagen.Size = new Size(800, 600); // tamano de la ventana.

            PictureBox imagenCompleta = new PictureBox(); // Crear un PictureBox para mostrar la imagen.
            imagenCompleta.Image = Image.FromFile(rutaImagen); // Cargar la imagen en el PictureBox.
            imagenCompleta.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen al PictureBox.
            imagenCompleta.Dock = DockStyle.Fill; // Ajustar el pictureBox al tamano de la ventana.

            ventanaImagen.Controls.Add(imagenCompleta); // Agregar el PictureBox a la ventana.
            ventanaImagen.ShowDialog(); // Mostrar la ventana.
        }

        // Método para eliminar una imagen seleccionada.
        public void EliminarImagen(object sender, EventArgs e, Control.ControlCollection controles)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem; // Obtener el item del menu.
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip; // Obtener el menu contextual.
            PictureBox pictureBoxSeleccionado = menu.SourceControl as PictureBox; // Obtener el PictureBox seleccionado.

            if (pictureBoxSeleccionado != null) // Si se selecciona un PictureBox.
            {
                controles.Remove(pictureBoxSeleccionado); // Eliminar el PictureBox del formulario.
                listaPictureBoxes.Remove(pictureBoxSeleccionado); // Eliminar el PictureBox de la lista.
                pictureBoxSeleccionado.Dispose(); // Liberar recursos del PictureBox.

                MessageBox.Show("Imagen eliminada correctamente."); // Mensaje de confirmacion que se borro la imagen.
            }
        }
    }
}
