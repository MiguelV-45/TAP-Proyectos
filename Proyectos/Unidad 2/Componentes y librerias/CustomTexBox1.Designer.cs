namespace CustomTexBox
{
    partial class CustomTexBox1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnAlfanumerico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(33, 91);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(75, 23);
            this.btnNumeros.TabIndex = 2;
            this.btnNumeros.Text = "Numeros";
            this.btnNumeros.UseVisualStyleBackColor = true;
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(169, 91);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(75, 23);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            // 
            // btnAlfanumerico
            // 
            this.btnAlfanumerico.Location = new System.Drawing.Point(287, 91);
            this.btnAlfanumerico.Name = "btnAlfanumerico";
            this.btnAlfanumerico.Size = new System.Drawing.Size(75, 23);
            this.btnAlfanumerico.TabIndex = 4;
            this.btnAlfanumerico.Text = "Alfa";
            this.btnAlfanumerico.UseVisualStyleBackColor = true;
            // 
            // CustomTexBox1
            // 
            this.Controls.Add(this.btnAlfanumerico);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.textBox1);
            this.Name = "CustomTexBox1";
            this.Size = new System.Drawing.Size(428, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnAlfanumerico;
    }
}
