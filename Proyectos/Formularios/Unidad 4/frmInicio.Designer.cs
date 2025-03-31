namespace Proyectos
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloI = new System.Windows.Forms.Label();
            this.btnSQLServer = new System.Windows.Forms.Button();
            this.btnMySQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloI
            // 
            this.lblTituloI.AutoSize = true;
            this.lblTituloI.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloI.Location = new System.Drawing.Point(21, 9);
            this.lblTituloI.Name = "lblTituloI";
            this.lblTituloI.Size = new System.Drawing.Size(214, 24);
            this.lblTituloI.TabIndex = 0;
            this.lblTituloI.Text = "Acceso a base de datos";
            // 
            // btnSQLServer
            // 
            this.btnSQLServer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSQLServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSQLServer.Location = new System.Drawing.Point(96, 74);
            this.btnSQLServer.Name = "btnSQLServer";
            this.btnSQLServer.Size = new System.Drawing.Size(160, 77);
            this.btnSQLServer.TabIndex = 1;
            this.btnSQLServer.Text = "SQL";
            this.btnSQLServer.UseVisualStyleBackColor = false;
            this.btnSQLServer.Click += new System.EventHandler(this.btnSQLServer_Click);
            // 
            // btnMySQL
            // 
            this.btnMySQL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMySQL.Location = new System.Drawing.Point(316, 74);
            this.btnMySQL.Name = "btnMySQL";
            this.btnMySQL.Size = new System.Drawing.Size(164, 77);
            this.btnMySQL.TabIndex = 2;
            this.btnMySQL.Text = "MySQL";
            this.btnMySQL.UseVisualStyleBackColor = false;
            this.btnMySQL.Click += new System.EventHandler(this.btnMySQL_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 209);
            this.Controls.Add(this.btnMySQL);
            this.Controls.Add(this.btnSQLServer);
            this.Controls.Add(this.lblTituloI);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloI;
        private System.Windows.Forms.Button btnSQLServer;
        private System.Windows.Forms.Button btnMySQL;
    }
}