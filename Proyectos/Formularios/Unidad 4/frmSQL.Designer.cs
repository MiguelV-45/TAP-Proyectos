
namespace Proyectos
{
    partial class frmSQL
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
            this.NControl = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.carrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreaTabla = new System.Windows.Forms.Button();
            this.btnCrearBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NControl
            // 
            this.NControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NControl.Location = new System.Drawing.Point(161, 36);
            this.NControl.MaxLength = 8;
            this.NControl.Name = "NControl";
            this.NControl.Size = new System.Drawing.Size(139, 26);
            this.NControl.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(161, 73);
            this.nombre.MaxLength = 50;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(415, 26);
            this.nombre.TabIndex = 3;
            // 
            // carrera
            // 
            this.carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrera.Location = new System.Drawing.Point(161, 110);
            this.carrera.MaxLength = 2;
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(46, 26);
            this.carrera.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero Control :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre :";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertar.Location = new System.Drawing.Point(62, 182);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(116, 54);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(5, 266);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 82;
            this.dgvAlumnos.RowTemplate.Height = 33;
            this.dgvAlumnos.Size = new System.Drawing.Size(793, 274);
            this.dgvAlumnos.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnActualizar.Location = new System.Drawing.Point(184, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 54);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBorrar.Location = new System.Drawing.Point(306, 182);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 54);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(428, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 54);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefrescar.Location = new System.Drawing.Point(603, 182);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(155, 54);
            this.btnRefrescar.TabIndex = 14;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Carrera :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreaTabla);
            this.groupBox1.Controls.Add(this.btnCrearBD);
            this.groupBox1.Location = new System.Drawing.Point(597, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 145);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de datos";
            // 
            // btnCreaTabla
            // 
            this.btnCreaTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreaTabla.Location = new System.Drawing.Point(6, 84);
            this.btnCreaTabla.Name = "btnCreaTabla";
            this.btnCreaTabla.Size = new System.Drawing.Size(155, 52);
            this.btnCreaTabla.TabIndex = 19;
            this.btnCreaTabla.Text = "Crear Tabla";
            this.btnCreaTabla.UseVisualStyleBackColor = false;
            this.btnCreaTabla.Click += new System.EventHandler(this.btnCreaTabla_Click_1);
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCrearBD.Location = new System.Drawing.Point(6, 24);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(155, 54);
            this.btnCrearBD.TabIndex = 18;
            this.btnCrearBD.Text = "Crear BD";
            this.btnCrearBD.UseVisualStyleBackColor = false;
            this.btnCrearBD.Click += new System.EventHandler(this.btnCrearBD_Click_1);
            // 
            // frmSQL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.NControl);
            this.Name = "frmSQL";
            this.Text = "Acceso a bases de datos SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NControl;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox carrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreaTabla;
        private System.Windows.Forms.Button btnCrearBD;
    }
}

