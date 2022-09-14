namespace pryGrafeuilleTP1Parte3
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombredelLibro = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombredelLibro
            // 
            this.lblNombredelLibro.AutoSize = true;
            this.lblNombredelLibro.Location = new System.Drawing.Point(12, 40);
            this.lblNombredelLibro.Name = "lblNombredelLibro";
            this.lblNombredelLibro.Size = new System.Drawing.Size(87, 13);
            this.lblNombredelLibro.TabIndex = 1;
            this.lblNombredelLibro.Text = "Nombre del Libro";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Location = new System.Drawing.Point(12, 65);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(80, 13);
            this.lblCodigoEditorial.TabIndex = 2;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Location = new System.Drawing.Point(12, 90);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(68, 13);
            this.lblCodigoAutor.TabIndex = 3;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.AutoSize = true;
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(12, 114);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoDistribuidor.TabIndex = 4;
            this.lblCodigoDistribuidor.Text = "Codigo distribuidor";
            this.lblCodigoDistribuidor.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMC
            // 
            this.lblMC.BackColor = System.Drawing.SystemColors.Window;
            this.lblMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMC.Location = new System.Drawing.Point(135, 9);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(77, 17);
            this.lblMC.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.Window;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Location = new System.Drawing.Point(135, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 17);
            this.lbl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(135, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(135, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(135, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 278);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblNombredelLibro);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombredelLibro;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

