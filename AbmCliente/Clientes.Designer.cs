﻿namespace FrbaHotel.AbmCliente
{
    partial class Clientes
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
            this.btnClientesCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientesCancelar
            // 
            this.btnClientesCancelar.Location = new System.Drawing.Point(639, 469);
            this.btnClientesCancelar.Name = "btnClientesCancelar";
            this.btnClientesCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnClientesCancelar.TabIndex = 0;
            this.btnClientesCancelar.Text = "Cancelar";
            this.btnClientesCancelar.UseVisualStyleBackColor = true;
            this.btnClientesCancelar.Click += new System.EventHandler(this.btnClientesSalir_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnClientesCancelar);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientesCancelar;
    }
}