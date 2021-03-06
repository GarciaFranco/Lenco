
namespace LenCo.Vista
{
    partial class frmDevoluciones
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtProductoEntra = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtProductoSale = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripDevolucion = new System.Windows.Forms.TextBox();
            this.lblRestante = new System.Windows.Forms.Label();
            this.lblSaliente = new System.Windows.Forms.Label();
            this.lblEntrante = new System.Windows.Forms.Label();
            this.lstSaliente = new System.Windows.Forms.ListBox();
            this.lstEntrante = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirEntrada = new System.Windows.Forms.Button();
            this.btnAñadirSalida = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(103, 180);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(248, 33);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Producto Entrante";
            // 
            // txtProductoEntra
            // 
            this.txtProductoEntra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoEntra.Location = new System.Drawing.Point(109, 234);
            this.txtProductoEntra.Name = "txtProductoEntra";
            this.txtProductoEntra.Size = new System.Drawing.Size(200, 29);
            this.txtProductoEntra.TabIndex = 1;
            this.txtProductoEntra.Enter += new System.EventHandler(this.txtProductoEntra_Enter);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(643, 180);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(244, 33);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Producto Saliente";
            // 
            // txtProductoSale
            // 
            this.txtProductoSale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoSale.Location = new System.Drawing.Point(638, 234);
            this.txtProductoSale.Name = "txtProductoSale";
            this.txtProductoSale.Size = new System.Drawing.Size(200, 29);
            this.txtProductoSale.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(253, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 36);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(535, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 29);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cod. Venta:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btnCancelar);
            this.gbDetalle.Controls.Add(this.label5);
            this.gbDetalle.Controls.Add(this.txtDescripDevolucion);
            this.gbDetalle.Controls.Add(this.lblRestante);
            this.gbDetalle.Controls.Add(this.lblSaliente);
            this.gbDetalle.Controls.Add(this.lblEntrante);
            this.gbDetalle.Controls.Add(this.lstSaliente);
            this.gbDetalle.Controls.Add(this.lstEntrante);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.btnConfirmar);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalle.Location = new System.Drawing.Point(109, 290);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(781, 319);
            this.gbDetalle.TabIndex = 11;
            this.gbDetalle.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Motivo:";
            // 
            // txtDescripDevolucion
            // 
            this.txtDescripDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripDevolucion.Location = new System.Drawing.Point(220, 184);
            this.txtDescripDevolucion.Multiline = true;
            this.txtDescripDevolucion.Name = "txtDescripDevolucion";
            this.txtDescripDevolucion.Size = new System.Drawing.Size(336, 86);
            this.txtDescripDevolucion.TabIndex = 20;
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestante.Location = new System.Drawing.Point(438, 86);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(21, 22);
            this.lblRestante.TabIndex = 19;
            this.lblRestante.Text = "0";
            // 
            // lblSaliente
            // 
            this.lblSaliente.AutoSize = true;
            this.lblSaliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaliente.Location = new System.Drawing.Point(438, 53);
            this.lblSaliente.Name = "lblSaliente";
            this.lblSaliente.Size = new System.Drawing.Size(21, 22);
            this.lblSaliente.TabIndex = 18;
            this.lblSaliente.Text = "0";
            // 
            // lblEntrante
            // 
            this.lblEntrante.AutoSize = true;
            this.lblEntrante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrante.Location = new System.Drawing.Point(438, 19);
            this.lblEntrante.Name = "lblEntrante";
            this.lblEntrante.Size = new System.Drawing.Size(21, 22);
            this.lblEntrante.TabIndex = 17;
            this.lblEntrante.Text = "0";
            // 
            // lstSaliente
            // 
            this.lstSaliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSaliente.FormattingEnabled = true;
            this.lstSaliente.ItemHeight = 20;
            this.lstSaliente.Location = new System.Drawing.Point(561, 22);
            this.lstSaliente.Name = "lstSaliente";
            this.lstSaliente.Size = new System.Drawing.Size(193, 144);
            this.lstSaliente.TabIndex = 16;
            // 
            // lstEntrante
            // 
            this.lstEntrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEntrante.FormattingEnabled = true;
            this.lstEntrante.ItemHeight = 20;
            this.lstEntrante.Location = new System.Drawing.Point(21, 22);
            this.lstEntrante.Name = "lstEntrante";
            this.lstEntrante.Size = new System.Drawing.Size(193, 144);
            this.lstEntrante.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monto saliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monto entrante:";
            // 
            // btnAñadirEntrada
            // 
            this.btnAñadirEntrada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAñadirEntrada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEntrada.Location = new System.Drawing.Point(315, 226);
            this.btnAñadirEntrada.Name = "btnAñadirEntrada";
            this.btnAñadirEntrada.Size = new System.Drawing.Size(43, 44);
            this.btnAñadirEntrada.TabIndex = 12;
            this.btnAñadirEntrada.Text = "+";
            this.btnAñadirEntrada.UseVisualStyleBackColor = false;
            this.btnAñadirEntrada.Click += new System.EventHandler(this.btnAñadirEntrada_Click);
            // 
            // btnAñadirSalida
            // 
            this.btnAñadirSalida.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAñadirSalida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirSalida.Location = new System.Drawing.Point(844, 226);
            this.btnAñadirSalida.Name = "btnAñadirSalida";
            this.btnAñadirSalida.Size = new System.Drawing.Size(43, 44);
            this.btnAñadirSalida.TabIndex = 13;
            this.btnAñadirSalida.Text = "+";
            this.btnAñadirSalida.UseVisualStyleBackColor = false;
            this.btnAñadirSalida.Click += new System.EventHandler(this.btnAñadirSalida_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(391, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 621);
            this.Controls.Add(this.btnAñadirSalida);
            this.Controls.Add(this.btnAñadirEntrada);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtProductoSale);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtProductoEntra);
            this.Controls.Add(this.lblEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevoluciones";
            this.Text = "frmDevoluciones";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtProductoEntra;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtProductoSale;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirEntrada;
        private System.Windows.Forms.Button btnAñadirSalida;
        private System.Windows.Forms.ListBox lstSaliente;
        private System.Windows.Forms.ListBox lstEntrante;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.Label lblSaliente;
        private System.Windows.Forms.Label lblEntrante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripDevolucion;
        private System.Windows.Forms.Button btnCancelar;
    }
}