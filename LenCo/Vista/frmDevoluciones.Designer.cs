
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
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.rbNotaCredito = new System.Windows.Forms.RadioButton();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtProductoSale = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirEntrada = new System.Windows.Forms.Button();
            this.btnAñadirSalida = new System.Windows.Forms.Button();
            this.lstEntrante = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(81, 164);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(317, 42);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Producto Entrante";
            // 
            // txtProductoEntra
            // 
            this.txtProductoEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoEntra.Location = new System.Drawing.Point(109, 227);
            this.txtProductoEntra.Name = "txtProductoEntra";
            this.txtProductoEntra.Size = new System.Drawing.Size(200, 44);
            this.txtProductoEntra.TabIndex = 1;
            this.txtProductoEntra.Enter += new System.EventHandler(this.txtProductoEntra_Enter);
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProducto.Location = new System.Drawing.Point(426, 213);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(104, 28);
            this.rbProducto.TabIndex = 2;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // rbNotaCredito
            // 
            this.rbNotaCredito.AutoSize = true;
            this.rbNotaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotaCredito.Location = new System.Drawing.Point(426, 247);
            this.rbNotaCredito.Name = "rbNotaCredito";
            this.rbNotaCredito.Size = new System.Drawing.Size(159, 28);
            this.rbNotaCredito.TabIndex = 3;
            this.rbNotaCredito.TabStop = true;
            this.rbNotaCredito.Text = "Nota de Credito";
            this.rbNotaCredito.UseVisualStyleBackColor = true;
            this.rbNotaCredito.CheckedChanged += new System.EventHandler(this.rbNotaCredito_CheckedChanged);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(610, 164);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(308, 42);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Producto Saliente";
            // 
            // txtProductoSale
            // 
            this.txtProductoSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoSale.Location = new System.Drawing.Point(638, 227);
            this.txtProductoSale.Name = "txtProductoSale";
            this.txtProductoSale.Size = new System.Drawing.Size(200, 44);
            this.txtProductoSale.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(907, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Historial";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(258, 133);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(265, 36);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(547, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 38);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cod. Venta:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.listBox2);
            this.gbDetalle.Controls.Add(this.lstEntrante);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.btnConfirmar);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Location = new System.Drawing.Point(109, 290);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(781, 192);
            this.gbDetalle.TabIndex = 11;
            this.gbDetalle.TabStop = false;
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
            this.btnAñadirEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEntrada.Location = new System.Drawing.Point(315, 227);
            this.btnAñadirEntrada.Name = "btnAñadirEntrada";
            this.btnAñadirEntrada.Size = new System.Drawing.Size(46, 44);
            this.btnAñadirEntrada.TabIndex = 12;
            this.btnAñadirEntrada.Text = "+";
            this.btnAñadirEntrada.UseVisualStyleBackColor = true;
            this.btnAñadirEntrada.Click += new System.EventHandler(this.btnAñadirEntrada_Click);
            // 
            // btnAñadirSalida
            // 
            this.btnAñadirSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirSalida.Location = new System.Drawing.Point(844, 226);
            this.btnAñadirSalida.Name = "btnAñadirSalida";
            this.btnAñadirSalida.Size = new System.Drawing.Size(46, 44);
            this.btnAñadirSalida.TabIndex = 13;
            this.btnAñadirSalida.Text = "+";
            this.btnAñadirSalida.UseVisualStyleBackColor = true;
            // 
            // lstEntrante
            // 
            this.lstEntrante.FormattingEnabled = true;
            this.lstEntrante.Location = new System.Drawing.Point(21, 22);
            this.lstEntrante.Name = "lstEntrante";
            this.lstEntrante.Size = new System.Drawing.Size(193, 147);
            this.lstEntrante.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(561, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 147);
            this.listBox2.TabIndex = 16;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductoSale);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.rbNotaCredito);
            this.Controls.Add(this.rbProducto);
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
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.RadioButton rbNotaCredito;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtProductoSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirEntrada;
        private System.Windows.Forms.Button btnAñadirSalida;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox lstEntrante;
    }
}