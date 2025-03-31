using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFCValidator;

namespace Proyectos
{
    public partial class FormControlesClases : Form
    {
        public FormControlesClases()
        {
            InitializeComponent();
        }

        private void btnValidarNumeros_Click(object sender, EventArgs e)
        {
            string texto = txtInput.Text;
            if (InputValidator.ValidadorNumerosLetras.EsSoloNumeros(texto))
            {
                lblResultado.Text = "👍 Solo contiene números.";
            }
            else
            {
                lblResultado.Text = "☠️ No son solo números.";
            }
        }

        private void btnValidarLetras_Click(object sender, EventArgs e)
        {
            string texto = txtInput.Text;
            if (InputValidator.ValidadorNumerosLetras.EsSoloLetras(texto))
            {
                lblResultado.Text = "👍 Solo contiene letras.";
            }
            else
            {
                lblResultado.Text = "☠️ No son solo letras.";
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string rfcIngresado = txtRFC.Text;
            string rfcNormalizado = RFCValidator.RFC.NormalizarRFC(rfcIngresado);
            bool esValido = RFCValidator.RFC.EsRFCValido(rfcNormalizado);

            // Mostrar el resultado de la validación en lblResultadoRFC
            if (esValido)
            {
                lblResultadoRFC.Text = $"RFC válido: {rfcNormalizado}"; // Mostrar RFC normalizado si es válido
                lblResultadoRFC.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultadoRFC.Text = "RFC inválido, Formato correcto: AAAA######XXX "; // Mostrar mensaje de RFC inválido
                lblResultadoRFC.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
