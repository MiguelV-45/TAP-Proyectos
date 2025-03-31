namespace Proyectos
{
    partial class FormControlesClases
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl11 = new Practica2ComponentesLibrerias.UserControl1();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnValidarNumeros = new System.Windows.Forms.Button();
            this.btnValidarLetras = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblResultadoRFC = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.userControl12 = new CustomTexBox.UserControl1();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(12, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 21);
            this.panel2.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.HoverBackColor = System.Drawing.Color.Red;
            this.userControl11.Location = new System.Drawing.Point(201, 127);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(99, 48);
            this.userControl11.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(209, 382);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // btnValidarNumeros
            // 
            this.btnValidarNumeros.Location = new System.Drawing.Point(86, 466);
            this.btnValidarNumeros.Name = "btnValidarNumeros";
            this.btnValidarNumeros.Size = new System.Drawing.Size(118, 23);
            this.btnValidarNumeros.TabIndex = 5;
            this.btnValidarNumeros.Text = "Validar Números";
            this.btnValidarNumeros.UseVisualStyleBackColor = true;
            this.btnValidarNumeros.Click += new System.EventHandler(this.btnValidarNumeros_Click);
            // 
            // btnValidarLetras
            // 
            this.btnValidarLetras.Location = new System.Drawing.Point(303, 466);
            this.btnValidarLetras.Name = "btnValidarLetras";
            this.btnValidarLetras.Size = new System.Drawing.Size(110, 23);
            this.btnValidarLetras.TabIndex = 6;
            this.btnValidarLetras.Text = "Validar Letras";
            this.btnValidarLetras.UseVisualStyleBackColor = true;
            this.btnValidarLetras.Click += new System.EventHandler(this.btnValidarLetras_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(220, 414);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(80, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado aquí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "a) Botón Personalizado (CustomButton)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "b) Caja de Texto Personalizada (CustomTextBox)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "a) Clase de Validación de Entrada (InputValidator)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "b) Clase de Validación de RFC (RFCValidator)";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(659, 382);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(245, 20);
            this.txtRFC.TabIndex = 12;
            // 
            // lblResultadoRFC
            // 
            this.lblResultadoRFC.AutoSize = true;
            this.lblResultadoRFC.Location = new System.Drawing.Point(740, 414);
            this.lblResultadoRFC.Name = "lblResultadoRFC";
            this.lblResultadoRFC.Size = new System.Drawing.Size(80, 13);
            this.lblResultadoRFC.TabIndex = 13;
            this.lblResultadoRFC.Text = "Resultado aquí";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(743, 478);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 14;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Implementación de Controles de Usuario Personalizados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Creación de Clases Reutilizables";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "* El color de fondo cambia cuando el cursor se pone arriba\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "* Tiene un evento personalizado, al dar doble clic sale un mensaje  confirmación\r" +
    "\n";
            // 
            // userControl12
            // 
            this.userControl12.EntradaPermitida = CustomTexBox.UserControl1.TipoEntrada.Numeros;
            this.userControl12.Location = new System.Drawing.Point(548, 90);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(428, 142);
            this.userControl12.TabIndex = 19;
            // 
            // FormControlesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 568);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblResultadoRFC);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidarLetras);
            this.Controls.Add(this.btnValidarNumeros);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.Name = "FormControlesClases";
            this.Text = "Biblioteca Controles y Clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Practica2ComponentesLibrerias.UserControl1 userControl11;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnValidarNumeros;
        private System.Windows.Forms.Button btnValidarLetras;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblResultadoRFC;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CustomTexBox.UserControl1 userControl12;
    }
}