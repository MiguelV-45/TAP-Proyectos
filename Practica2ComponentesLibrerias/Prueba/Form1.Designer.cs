﻿namespace Prueba
{
    partial class Form1
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
            this.userControl11 = new Practica2ComponentesLibrerias.UserControl1();
            this.userControl12 = new CustomTexBox.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.HoverBackColor = System.Drawing.Color.Red;
            this.userControl11.Location = new System.Drawing.Point(60, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(99, 48);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.EntradaPermitida = CustomTexBox.UserControl1.TipoEntrada.Numeros;
            this.userControl12.Location = new System.Drawing.Point(40, 88);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(428, 142);
            this.userControl12.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 565);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Practica2ComponentesLibrerias.UserControl1 userControl11;
        private CustomTexBox.UserControl1 userControl12;
    }
}

