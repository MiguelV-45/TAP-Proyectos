namespace Proyectos
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesYClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.gUIDinamicaToolStripMenuItem,
            this.controlesYClasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // gUIDinamicaToolStripMenuItem
            // 
            this.gUIDinamicaToolStripMenuItem.Name = "gUIDinamicaToolStripMenuItem";
            this.gUIDinamicaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gUIDinamicaToolStripMenuItem.Text = "GUI Dinamica";
            this.gUIDinamicaToolStripMenuItem.Click += new System.EventHandler(this.gUIDinamicaToolStripMenuItem_Click);
            // 
            // controlesYClasesToolStripMenuItem
            // 
            this.controlesYClasesToolStripMenuItem.Name = "controlesYClasesToolStripMenuItem";
            this.controlesYClasesToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.controlesYClasesToolStripMenuItem.Text = "Componentes y Clases";
            this.controlesYClasesToolStripMenuItem.Click += new System.EventHandler(this.controlesYClasesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu de practicas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUIDinamicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesYClasesToolStripMenuItem;
    }
}

