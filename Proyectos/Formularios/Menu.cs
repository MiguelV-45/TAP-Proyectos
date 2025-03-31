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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestion frm1 = new FormGestion();
            frm1.Show();
        }

        private void gUIDinamicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGUI_Dinamico frm2 = new FormGUI_Dinamico();
            frm2.Show();
        }

        private void componentesYClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControlesClases frm3 = new FormControlesClases();
            frm3.Show();
        }

        private void concurrencianumerosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImplementacionHilos frm4 = new FormImplementacionHilos();
            frm4.Show();
        }

        private void accesoABaseDeDatos1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frm5 = new frmInicio();
            frm5.Show();
        }
    }
}
