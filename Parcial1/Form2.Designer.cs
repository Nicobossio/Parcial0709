﻿
namespace Parcial1
{
    partial class Form2
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
            this.lblSold = new System.Windows.Forms.Label();
            this.rtxtVentas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblSold.Location = new System.Drawing.Point(52, 23);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(44, 15);
            this.lblSold.TabIndex = 0;
            this.lblSold.Text = "Ventas";
            // 
            // rtxtVentas
            // 
            this.rtxtVentas.Location = new System.Drawing.Point(55, 54);
            this.rtxtVentas.Name = "rtxtVentas";
            this.rtxtVentas.Size = new System.Drawing.Size(690, 273);
            this.rtxtVentas.TabIndex = 1;
            this.rtxtVentas.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtVentas);
            this.Controls.Add(this.lblSold);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.RichTextBox rtxtVentas;
    }
}