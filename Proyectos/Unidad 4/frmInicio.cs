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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCredenciales credenciales = new frmCredenciales("SQL");
            credenciales.ShowDialog();
            this.Show();
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCredenciales credenciales = new frmCredenciales("MySQL");
            credenciales.ShowDialog();
            this.Show();
        }
    }
}
