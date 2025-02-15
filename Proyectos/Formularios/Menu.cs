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

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestion frm1 = new FormGestion();
            frm1.Show();
        }

        private void gUIDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGUI_Dinamico frm2 = new FormGUI_Dinamico();
            frm2.Show();
        }
    }
}
